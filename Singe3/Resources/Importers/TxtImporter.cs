using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singe3.Resources.Importers
{
    public class TxtImporter : IResourceImporter<string>
    {
        public string GetFileType()
        {
            return "txt";
        }

        public ResourceType GetResourceType()
        {
            return ResourceType.Text;
        }

        public string Import(byte[] data)
        {
            using var stream = new MemoryStream(data, false);

            using var reader = new StreamReader(stream);

            return reader.ReadToEnd();
        }
    }
}
