using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Singe3.Resources.Importers
{
    public sealed class MaterialImporter : IResourceImporter<object>
    {
        public MaterialImporter()
        {
        }

        public string GetFileType()
        {
            return "mat.json";
        }

        public ResourceType GetResourceType()
        {
            return ResourceType.Material;
        }

        public object Import(byte[] data)
        {
            using var memoryStream = new MemoryStream(data);
            
            using var stringReader = new StreamReader(memoryStream);

            return JsonSerializer.Deserialize(stringReader.ReadToEnd(), null);
        }
    }
}
