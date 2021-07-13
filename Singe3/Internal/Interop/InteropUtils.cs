using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Singe3
{
    internal static unsafe class InteropUtils
    {
        const int TYPE_GUID_CHUNK_SIZE = 64;

        static int nextGuidIndex = 0;
        static Type[] types = new Type[TYPE_GUID_CHUNK_SIZE];
        static Guid[] guids = new Guid[TYPE_GUID_CHUNK_SIZE];

        public static Guid GetGuid<T>()
        {
            return typeof(T).GUID;
        }

        public static Guid* GetGuidPtr<T>()
        {
            if (!types.Contains(typeof(T)))
            {
                types[nextGuidIndex] = typeof(T);
                guids[nextGuidIndex] = typeof(T).GUID;
                nextGuidIndex++;
                if(nextGuidIndex >= types.Length)
                {
                    var oldTypes = types;
                    types = new Type[oldTypes.Length + TYPE_GUID_CHUNK_SIZE];
                    Array.Copy(oldTypes, types, oldTypes.Length);

                    var oldGuids = guids;
                    guids = new Guid[oldGuids.Length + TYPE_GUID_CHUNK_SIZE];
                    Array.Copy(oldGuids, guids, oldGuids.Length);
                }
            }

            fixed (Guid* guid = guids)
                return &guid[Array.IndexOf(types, typeof(T))];
        }

        //public static PCSTR StringToPCSTR(string s)
        //{
        //    return (PCSTR)Marshal.StringToHGlobalAnsi(s).ToPointer();
        //}

        //public static void FreePCSTR(PCSTR pcstr)
        //{
        //    Marshal.FreeHGlobal((IntPtr)pcstr.Value);
        //}
    }
}
