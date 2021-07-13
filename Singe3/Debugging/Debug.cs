using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singe3.Debugging
{
    public sealed class Debug : Subsystem
    {
        private Debug()
        {

        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }

        public void Warn(string warning)
        {
            Warn(null, warning);
        }

        public void Warn(object source, string warning)
        {
            Console.WriteLine($"WARNING: {source}: {warning}");
        }

        public static Debug Create()
        {
            return new Debug();
        }
    }
}
