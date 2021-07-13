using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singe3
{
    /// <summary>
    /// When applied to a class which inherits from <see cref="Subsystem"/>, allows a single instance of that class on any given <see cref="ApplicationContext"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    sealed class SingleSubsystemAttribute : Attribute
    {
        /// <summary>
        /// Creates a new instance of the <see cref="SingleSubsystemAttribute"/> class.
        /// </summary>
        public SingleSubsystemAttribute()
        {
        }
    }
}
