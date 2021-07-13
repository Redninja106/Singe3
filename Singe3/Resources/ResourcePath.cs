using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Singe3.Resources
{
    public record ResourcePath
    {
        /// <summary>
        /// A boolean indicating if this <see cref="ResourcePath"/> instance's Properties can be set.
        /// </summary>
        public bool IsReadonly { get; internal set; }

        /// <summary>
        /// The path to the resource. This property can only be set if <see cref="IsReadonly"/> is false.
        /// </summary>
        public string Path { get => path; set => path = IsReadonly ? throw new Exception("This ResourcePath instance is readonly!") : value; }

        /// <summary>
        /// A <see cref="ResourceLocation"/> indicating the storage system that this asset is located in. This property can only be set if <see cref="IsReadonly"/> is false.
        /// </summary>
        public ResourceLocation Location { get => location; set => location = IsReadonly ? throw new Exception("This ResourcePath instance is readonly!") : value; }

        private string path;

        private ResourceLocation location;

        /// <summary>
        /// Creates a new instance of the <see cref="ResourcePath"/> class.
        /// </summary>
        /// <param name="path">The path to the resource.</param>
        public ResourcePath(string path) : this (path, ResourceLocation.Unknown)
        {

        }

        /// <summary>
        /// Creates a new instance of the <see cref="ResourcePath"/> class.
        /// </summary>
        /// <param name="path">The path to the resource.</param>
        /// <param name="location">A <see cref="ResourceLocation"/> indicating the storage system that this asset is located in. </param>
        public ResourcePath(string path, ResourceLocation location)
        {
            IsReadonly = false;
            this.Path = path;
            this.Location = location;
        }

        /// <summary>
        /// Gets the file extension at the end of this path.
        /// </summary>
        /// <returns>The file extension.</returns>
        public string GetFileExtension()
        {
            int extensionIndex;
            if (location == ResourceLocation.FileSystem)
            {
                extensionIndex = this.Path.Replace("./", "  ").IndexOf('.') + 1;
            }
            else
            {
                extensionIndex = this.Path.LastIndexOf('.') + 1;

            }
            return this.Path[extensionIndex..];
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{{{Location}: {Path}}}";
        }
    }
}
