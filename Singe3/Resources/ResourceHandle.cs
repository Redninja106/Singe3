using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singe3.Resources
{
    /// <summary>
    /// Represents a loaded or unloaded resource in any location.
    /// </summary>
    public class ResourceHandle
    {
        // the id of the next created ResourceHandle.
        private static uint nextId = 1;

        /// <summary>
        /// The <see cref="ResourceLoader"/> which created this handle.
        /// </summary>
        public ResourceLoader Loader { get; private set; }

        /// <summary>
        /// The path to the resource.
        /// </summary>
        public ResourcePath Path { get; private set; }
        
        /// <summary>
        /// The unique identifier of the resource handle.
        /// </summary>
        public uint ID { get; private set; }

        /// <summary>
        /// Indicates is the resource is loaded.
        /// </summary>
        public bool IsLoaded => resource != null;

        /// <summary>
        /// Indicates if the resource's raw bytes are loaded.
        /// </summary>
        public bool IsLoadedRaw => rawResource != null;

        /// <summary>
        /// The file extension of the resource. This is used to determine it's default <see cref="IResourceImporter"/>.
        /// </summary>
        public string Extension => Path.GetFileExtension();

        /// <summary>
        /// The default <see cref="IResourceImporter"/> that this resource uses.
        /// </summary>
        public IResourceImporter<object> Importer => Loader.GetImporter(this.Extension);

        /// <summary>
        /// The type of the resource as a <see cref="ResourceType"/>, determined by the file extension.
        /// </summary>
        public ResourceType Type => Loader.GetTypeForExtension(this.Extension);

        // the loaded resource, null if not loaded. 
        private object resource;

        // the raw bytes of the resource, null if not loaded.
        private byte[] rawResource;

        /// <summary>
        /// Creates a new instance of the <see cref="ResourceHandle"/> class.
        /// </summary>
        /// <param name="loader">The <see cref="ResourceLoader"/> which created this handle.</param>
        /// <param name="path">The path to the resource.</param>
        internal ResourceHandle(ResourceLoader loader, ResourcePath path)
        {
            this.Loader = loader;
            this.Path = path;
            this.ID = nextId++;
        }

        /// <summary>
        /// Returns the object created by the <see cref="IResourceImporter{T}"/> used to import this reosurce.
        /// </summary>
        public object GetResource()
        {
            return resource;
        }

        /// <summary>
        /// Returns the object created by the <see cref="IResourceImporter{T}"/> used to import this reosurce.
        /// </summary>
        /// <typeparam name="T">The type to try to cast the resource to.</typeparam>
        public T GetResource<T>()
        {
            return (T)resource;
        }

        /// <summary>
        /// Returns a <see cref="ReadOnlySpan{T}"/> of the bytes that make up the unimported, raw data of this resource.
        /// </summary>
        public ReadOnlyMemory<byte> GetRawResource()
        {
            return rawResource;
        }

        /// <summary>
        /// Sets the raw data for the resource, setting the <see cref="IsLoadedRaw"/> property to true (unless <paramref name="data"/> is <see langword="null"/>).
        /// </summary>
        /// <param name="data"></param>
        internal void SetRawData(byte[] data)
        {
            this.rawResource = data;
        }

        /// <summary>
        /// Sets the object for the loaded resource, setting the <see cref="IsLoaded"/> property to true (unless <paramref name="resource"/> is <see langword="null"/>).
        /// </summary>
        /// <param name="resource"></param>
        internal void SetResource(object resource)
        {
            this.resource = resource;
        }
    }
}