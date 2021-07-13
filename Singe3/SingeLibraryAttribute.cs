using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singe3
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = false)]
    public sealed class SingeLibraryAttribute : Attribute
    {
        public SingeLibraryAttribute()
        {
        }
    }
}
