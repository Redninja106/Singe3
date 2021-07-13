using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singe3
{
    /// <summary>
    /// This attribute only applies to classes derived from <see cref="Subsystem"/>. Allows subsystems control the order in which they're initialized relative to one another.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public sealed class CallAfterAttribute : Attribute
    {
        /// <summary>
        /// Creates a new instance of the <see cref="CallAfterAttribute"/> class.
        /// </summary>
        /// <param name="subsystems"></param>
        public CallAfterAttribute(CoreSubsystem subsystems) : this(Utility.CoreSubsystemToTypes(subsystems))
        {
        }

        public CallAfterAttribute(params Type[] subsystems)
        {
            this.Subsystems = subsystems;
        }

        public Type[] Subsystems { get; private set; }
    }
}
