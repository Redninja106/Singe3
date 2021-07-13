using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Singe3.Resources
{
    [SingleSubsystem]
    public sealed class ResourceLoader : Subsystem
    {
        /// <summary>
        /// Indicates if the <see cref="GatherHandles"/> function has been called and the <see cref="ResourceLoader"/> has handles to available resources.
        /// </summary>
        public bool HasHandles { get; private set; }

        private List<ResourceHandle> resourceHandles;

        private Dictionary<string, IResourceImporter<object>> importers;

        private ResourceLoader()
        {
            importers = new Dictionary<string, IResourceImporter<object>>();
        }

        public override void OnInitialize(ApplicationContext context)
        {
            var importerTypes = this.FindAllImporters(context.AssemblyRegistry.InternalAssemblies[0]);

            var importers = this.CreateImporters(importerTypes);

            foreach (var importer in importers)
            {
                RegisterImporter(importer);
            }

            if (resourceHandles == null)
                GatherHandles();

            base.OnInitialize(context);
        }

        /// <summary>
        /// Creates ResourceHandles for available resources. This method must be called before trying to obtain any ResourceHandle references. <see cref="HasHandles"/> indicates if this method has been called.
        /// </summary>
        /// <param name="rootFolder">The name of the root folder which contains all of this project's assets.</param>
        public void GatherHandles(string rootFolder = "Assets")
        {
            resourceHandles = new List<ResourceHandle>();

            // register embedded resources
            string assemblyName = ApplicationContext.AssemblyRegistry.GameAssembly.GetName().Name;
            
            foreach (var resourcePath in ApplicationContext.AssemblyRegistry.GameAssembly.GetManifestResourceNames())
            {
                resourceHandles.Add(new ResourceHandle(this, new ResourcePath($"{assemblyName}::{resourcePath}", ResourceLocation.EmbeddedResource)));
            }

            foreach (var library in ApplicationContext.AssemblyRegistry.LibraryAssemblies)
            {
                assemblyName = library.GetName().Name;

                foreach (var resourcePath in library.GetManifestResourceNames())
                {
                    resourceHandles.Add(new ResourceHandle(this, new ResourcePath($"{assemblyName}::{resourcePath}", ResourceLocation.EmbeddedResource)));
                }
            }

            foreach (var internalAssembly in ApplicationContext.AssemblyRegistry.InternalAssemblies)
            {
                assemblyName = internalAssembly.GetName().Name;

                foreach (var resourcePath in internalAssembly.GetManifestResourceNames())
                {
                    resourceHandles.Add(new ResourceHandle(this, new ResourcePath($"{assemblyName}::{resourcePath}", ResourceLocation.EmbeddedResource)));
                }
            }

            // discover files
            var rootPath = Path.Combine(Environment.CurrentDirectory, rootFolder);

            GatherFileHandles(rootPath);

            HasHandles = true;
        }

        /// <summary>
        /// <para>
        /// Loads a resource from the provided resource handle, using the resource's default importer. If the resource is already loaded, this methods just returns that resource.
        /// </para>
        /// <para>
        /// In addition to being returned, the loaded resource can be retrieved using <see cref="ResourceHandle.GetResource"/>. The resource can be unloaded using the <see cref="Unload(ResourceHandle)"/>.
        /// </para>
        /// </summary>
        /// <typeparam name="T">The type of resource that is being loaded.</typeparam>
        /// <param name="resource">The resource handle of the resource to load.</param>
        /// <returns>The loaded resource. This can be a newly loaded one or one that was previously loaded for this handle.</returns>
        public T Load<T>(ResourceHandle resource)
        {
            return (T)Load(resource);
        }

        /// <summary>
        /// <para>
        /// Loads a resource from the provided resource handle, using the resource's default importer. If the resource is already loaded, this methods just returns that resource.
        /// </para>
        /// <para>
        /// In addition to being returned, the loaded resource can be retrieved using <see cref="ResourceHandle.GetResource"/>. The resource can be unloaded using the <see cref="Unload(ResourceHandle)"/>.
        /// </para>
        /// </summary>
        /// <param name="resource"></param>
        /// <returns>The loaded resource. This can be a newly loaded one or one that was previously loaded for this handle.</returns>
        public object Load(ResourceHandle resource)
        {
            return Load(resource, resource.Importer);
        }

        /// <summary>
        /// <para>
        /// Loads a resource from the provided resource handle, using the provided importer. If the resource is already loaded, this methods just returns that resource.
        /// </para>
        /// <para>
        /// In addition to being returned, the loaded resource can be retrieved using <see cref="ResourceHandle.GetResource"/>. The resource can be unloaded using the <see cref="Unload(ResourceHandle)"/>.
        /// </para>
        /// </summary>
        /// <typeparam name="T">The type of resource that is being loaded.</typeparam>
        /// <param name="resource">The resource handle of the resource to load.</param>
        /// <param name="importer">The importer to use.</param>
        /// <returns>The loaded resource. This can be a newly loaded one or one that was previously loaded for this handle.</returns>
        public T Load<T>(ResourceHandle resource, IResourceImporter<T> importer)
        {
            return Load(resource, importer);
        }

        /// <summary>
        /// <para>
        /// Loads a resource from the provided resource handle, using the provided importer. If the resource is already loaded, this methods just returns that resource.
        /// </para>
        /// <para>
        /// In addition to being returned, the loaded resource can be retrieved using <see cref="ResourceHandle.GetResource"/>. The resource can be unloaded using the <see cref="Unload(ResourceHandle)"/>.
        /// </para>
        /// </summary>
        /// <param name="resource">The resource handle of the resource to load.</param>
        /// <param name="importer">The importer to use.</param>
        /// <returns>The loaded resource. This can be a newly loaded one or one that was previously loaded for this handle.</returns>
        public object Load(ResourceHandle resource, IResourceImporter<object> importer)
        {
            if (resource.IsLoaded)
            {
                return resource.GetResource();
            }

            bool wasRawDataLoaded = resource.IsLoadedRaw;

            byte[] data = LoadRaw(resource);

            object result = importer.Import(data);

            if (!wasRawDataLoaded)
            {
                UnloadRaw(resource);
            }

            return result;
        }

        /// <summary>
        /// Loads the raw bytes of a resource from the provided resource handle. If the resource's raw data is already loaded, this methods just returns that resource.
        /// </summary>
        /// <param name="resource">The resource handle of the resource to load.</param>
        /// <returns>The raw data of the resource as an array of bytes.</returns>
        public byte[] LoadRaw(ResourceHandle resource)
        {
            Stream resourceStream = null;

            switch (resource.Path.Location)
            {
                case ResourceLocation.EmbeddedResource:
                    var parts = resource.Path.Path.Split("::");

                    if (parts.Length != 2)
                    {
                        // something has gone wrong. format is supposed to be [assemblyName]::[resourcePath]
                        throw new Exception();
                    }

                    var assembly = Assembly.Load(parts[0]);
                    var path = parts[1];

                    resourceStream = assembly.GetManifestResourceStream(path);
                    break;
                case ResourceLocation.FileSystem:
                    resourceStream = File.OpenRead(resource.Path.Path);
                    break;
                default:
                    break;
            }

            if (resourceStream == null)
                throw new Exception($"Unable to retrieve resource stream for {resource}");

            byte[] result = new byte[resourceStream.Length];
            
            resourceStream.Read(result, 0, result.Length);

            resourceStream.Dispose();

            return result;
        }

        /// <summary>
        /// Unloads a resource, saving memory. However, all references to the loaded resource represented by the provided handle will become invalid and the resource will have to be loaded again in order to be accessed.
        /// </summary>
        /// <param name="resource"></param>
        public void Unload(ResourceHandle resource)
        {
            if (resource.IsLoaded)
            {
                resource.SetResource(null);
            }
        }
        
        /// <summary>
        /// Unloads the raw bytes of a resource, saving memory. However, all references to the loaded resource's data represented by the provided handle will become invalid and the raw data of the resource will have to be loaded again in order to be accessed.
        /// </summary>
        /// <param name="resource"></param>
        public void UnloadRaw(ResourceHandle resource)
        {
            if (resource.IsLoadedRaw)
            {
                resource.SetRawData(null);
            }
        }

        public IResourceImporter<T> GetImporter<T>(string fileExtension)
        {
            return (IResourceImporter<T>)GetImporter(fileExtension);
        }

        public IResourceImporter<object> GetImporter(string fileExtension)
        {
            return importers[fileExtension];
        }

        public bool RegisterImporter<T>(IResourceImporter<T> importer)
        {
            return RegisterImporter(importer);
        }

        public bool RegisterImporter(IResourceImporter<object> importer)
        {
            var fileType = importer.GetFileType().Trim();

            if (fileType.StartsWith('.'))
            {
                fileType = fileType[1..];
            }

            if (importers.ContainsKey(fileType))
            {
                return false;
            }

            importers.Add(fileType, importer);

            return true;
        }

        public IEnumerable<ResourceHandle> GetAllResourceHandles()
        {
            return resourceHandles;
        }

        public IEnumerable<ResourceHandle> GetAllFileResourceHandles()
        {
            return GetAllResourceHandles().Where(handle => handle.Path.Location == ResourceLocation.FileSystem);
        }

        public IEnumerable<ResourceHandle> GetAllEmbeddedResourceHandles()
        {
            return GetAllResourceHandles().Where(handle => handle.Path.Location == ResourceLocation.EmbeddedResource);
        }

        public IEnumerable<ResourceHandle> GetAllEmbeddedResourceHandles(Assembly assembly)
        {
            return GetAllEmbeddedResourceHandles(assembly.FullName);
        }

        public IEnumerable<ResourceHandle> GetAllEmbeddedResourceHandles(string assembly)
        {
            return GetAllResourceHandles().Where(handle => handle.Path.Path.Split("::").First() == assembly);
        }

        public IEnumerable<ResourceHandle> GetAllLoadedResources()
        {
            return GetAllResourceHandles().Where(handle => handle.IsLoaded);
        }

        public IEnumerable<ResourceHandle> GetAllResourcesWithName(string fileName)
        {
            return GetAllResourceHandles().Where(handle => handle.Path.Path.EndsWith(fileName));
        }

        public IEnumerable<ResourceHandle> GetAllResourcesWithExtension(string extension)
        {
            return GetAllResourceHandles().Where(handle => handle.Path.Path.EndsWith(extension));
        }

        public ResourceHandle GetResourceHandle(ResourcePath path)
        {
            return GetAllResourceHandles().Where(handle => handle.Path == path).FirstOrDefault();
        }

        internal ResourceType GetTypeForExtension(string extension)
        {
            return importers[extension].GetResourceType();
        }

        protected override void Dispose(bool disposing)
        {
            foreach (var resourceHandle in resourceHandles)
            {
                Unload(resourceHandle);
            }
            base.Dispose(disposing);
        }

        public static ResourceLoader Create()
        {
            return new ResourceLoader();
        }

        // try to determine where the resource specified by this path is located.
        private static ResourceLocation InferResourceLocation(string path)
        {
            throw new NotImplementedException();
        }

        // recursively search for files and add them to the resourceHandle list.
        private void GatherFileHandles(string directory)
        {
            foreach (var file in Directory.GetFiles(directory))
            {
                resourceHandles.Add(new ResourceHandle(this, new ResourcePath(file, ResourceLocation.FileSystem)));
            }

            foreach (var folder in Directory.GetDirectories(directory))
            {
                GatherFileHandles(folder);
            }
        }

        // find and return all importers in a given assembly
        private IEnumerable<Type> FindAllImporters(Assembly assembly)
        {
            var result = new List<Type>();

            foreach (var type in assembly.ExportedTypes)
            {
                if (type.IsAssignableTo(typeof(IResourceImporter<object>)))
                {
                    result.Add(type);
                }    
            }

            return result;
        }

        // given an array of a types of importers, create a instance for each one
        private IEnumerable<IResourceImporter<object>> CreateImporters(IEnumerable<Type> importerTypes)
        {
            var result = new List<IResourceImporter<object>>();

            foreach (var type in importerTypes)
            {
                var ctor = type.GetConstructor(Array.Empty<Type>());

                if (ctor == null)
                {
                    continue;
                }

                result.Add((IResourceImporter<object>)ctor.Invoke(null));
            }

            return result;
        }
    }
}
