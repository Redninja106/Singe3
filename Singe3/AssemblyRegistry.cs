using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Singe3
{
    /// <summary>
    /// Manages reflection and some loaded assemblies.
    /// </summary>
    public sealed class AssemblyRegistry
    {
        public Assembly GameAssembly { get; private set; }
        public IReadOnlyList<Assembly> LibraryAssemblies => libraryAssemblies;
        public IReadOnlyList<Assembly> InternalAssemblies => internalAssemblies;

        private List<Assembly> libraryAssemblies;
        private List<Assembly> internalAssemblies;

        internal AssemblyRegistry()
        {
            libraryAssemblies = new List<Assembly>();
            internalAssemblies = new List<Assembly>();

            GameAssembly = Assembly.GetEntryAssembly();

            internalAssemblies.Add(Assembly.Load(nameof(Singe3)));

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            foreach (var assembly in assemblies)
            {
                if (assembly.GetCustomAttribute<SingeLibraryAttribute>() != null)
                {
                    libraryAssemblies.Add(assembly);
                }
            }
        }

        /// <summary>
        /// Gets the first occurance of a type with the specified attribute in the provided assembly.
        /// </summary>
        /// <typeparam name="T">The type of attribute.</typeparam>
        /// <param name="assembly">The assembly to get the type from.</param>
        /// <returns>The first type with this attribute.</returns>
        public Type GetTypeWithAttribute<T>(Assembly assembly)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Type> GetTypesWithBaseInAssembly(Type baseType, Assembly assembly)
        {
            var result = new List<Type>();

            foreach (var type in assembly.DefinedTypes)
            {
                if (type.IsSubclassOf(baseType))
                {
                    result.Add(type);
                }
            }

            return result;
        }

        /// <summary>
        /// Gets all of the types in an assembly which implement the provided interface.
        /// </summary>
        /// <param name="baseType"></param>
        /// <param name="assembly"></param>
        /// <returns></returns>
        public IEnumerable<Type> GetTypesForInterfaceInAssembly(Type interfaceType, Assembly assembly)
        {
            var result = new List<Type>();

            foreach (var type in assembly.DefinedTypes)
            {
                if (type.ImplementedInterfaces.Contains(interfaceType))
                {
                    result.Add(type);
                }
            }

            return result;
        }
    }
}
