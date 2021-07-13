using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Windows.Win32.UI.WindowsAndMessaging;

namespace Singe3.Platforms.Implementations.Windows.Util
{
    /// <summary>
    /// For extracting the low-order and high-order 16-bit words from a 32-bit value. Seems niche, but is very useful in the windows api.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    internal struct Union
    {
        public unsafe Union(LPARAM val)
        {
            low = high = 0;
            ulow = uhigh = 0;
            this.Value = (int)val.Value;
        }
        public unsafe Union(WPARAM val)
        {
            low = high = 0;
            ulow = uhigh = 0;
            this.Value = (int)val.Value;
        }

        [FieldOffset(0)]
        public int Value;
        [FieldOffset(0)]
        public short low;
        [FieldOffset(2)]
        public short high;
        [FieldOffset(0)]
        public ushort ulow;
        [FieldOffset(2)]
        public ushort uhigh;
    }
}
