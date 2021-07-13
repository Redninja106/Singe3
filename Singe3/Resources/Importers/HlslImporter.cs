using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singe3.Resources.Importers
{
    public sealed class HlslImporter : IResourceImporter<string>
    {
        public string GetFileType()
        {
            return "hlsl";
        }

        public ResourceType GetResourceType()
        {
            return ResourceType.Shader;
        }

        public string Import(byte[] data)
        {
            using var stream = new MemoryStream(data, false);

            using var reader = new StreamReader(stream);

            return reader.ReadToEnd();
        }
    }
}
