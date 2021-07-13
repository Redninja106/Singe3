using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singe3.Resources
{
    public interface IResourceImporter<out T>
    {
        public ResourceType GetResourceType();

        public string GetFileType();

        public T Import(byte[] data);
    }
}
