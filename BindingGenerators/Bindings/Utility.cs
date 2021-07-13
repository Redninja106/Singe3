using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Singe3.Bindings.Platforms.Windows;

namespace Singe3.Bindings
{
    public static unsafe class Utility
    {
        //public static Guid* __uuidOf<T>(T obj = default)
        //{
        //    return new Guid(typeof(T).GetCustomAttribute<GuidAttribute>().);
        //}

        public struct FixedBufferView<T> where T : unmanaged
        {
            public T this[int index]
            {
                get 
                { 
                    fixed (FixedBufferView<T>* pThis = &this)
                    {
                        return ((T*)pThis)[index];
                    }
                }
                
                set 
                {
                    fixed (FixedBufferView<T>* pThis = &this)
                    {
                        ((T*)pThis)[index] = value;
                    }
                }
            }
        }
    }
}
