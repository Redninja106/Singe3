using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Singe3.Bindings.Platforms
{
    public unsafe class Windows
    {
        public struct HRESULT
        {
            public HRESULT(int value)
            {
                this.Value = value;
            }

            public int Value;

            public bool Failure()
            {
                return Value < 0;
            }

            public bool Success()
            {
                return Value >= 0;
            }

            public void ThrowIfFailed()
            {
                if (Failure())
                {
                    throw new Exception($"Error 0x{Value:x}");
                }
            }

            public static implicit operator int(HRESULT result)
            {
                return result.Value;
            }
           
            public static implicit operator HRESULT(int result)
            {
                return *(HRESULT*)&result;
            }
            
            public static bool operator true(HRESULT result)
            {
                return result.Success();
            }

            public static bool operator !(HRESULT result)
            {
                return result.Failure();
            }
            
            public static bool operator false(HRESULT result)
            {
                return result.Failure();
            }
        }

        public struct LUID
        {
            public uint LowPart;
            public uint HighPart;
        }

        public struct HANDLE { public void* ptr; }

        public struct HINSTANCE
        {
            private void* ptr;

            public HINSTANCE(void* ptr)
            {
                this.ptr = ptr;
            }

            public void* ToPointer()
            {
                return ptr;
            }

            public static implicit operator HINSTANCE(HMODULE module)
            {
                return *(HINSTANCE*)&module;

            }

            public static implicit operator HINSTANCE(void* ptr)
            {
                return *(HINSTANCE*)&ptr;
            }
        }

        public struct HMODULE
        {
            private void* ptr;

            public HMODULE(void* ptr)
            {
                this.ptr = ptr;
            }

            public void* ToPointer()
            {
                return ptr;
            }

            public static implicit operator HMODULE(HINSTANCE module)
            {
                return *(HMODULE*)&module;
            }

            public static explicit operator HMODULE(void* ptr)
            {
                return *(HMODULE*)&ptr;
            }
        }

        public struct IID
        {
            private Guid guid;

            public static implicit operator Guid(IID iid)
            {
                return *(Guid*)&iid;
            }

            public static implicit operator IID(Guid guid)
            {
                return *(IID*)&guid;
            }
        }

        public struct REFIID
        {
            private IID iid;

            public static implicit operator REFIID(IID iid)
            {
                return new REFIID { iid = iid };
            }

            //public static implicit operator REFIID(IID* iid)
            //{
            //    return *(REFIID*)&iid;
            //}

            //public static implicit operator REFIID(Guid* guid)
            //{
            //    return *(REFIID*)&guid;
            //}

            //public static implicit operator Guid*(REFIID refiid)
            //{
            //    return (Guid*)refiid.iid;
            //}

            //public static implicit operator IID*(REFIID refiid)
            //{
            //    return refiid.iid;
            //}

            //public IID Dereference()
            //{
            //    return *iid;
            //}
        }

        public struct REFGUID
        {
            private Guid* guid;

            public static implicit operator REFGUID(IID* iid)
            {
                return *(REFGUID*)&iid;
            }

            public static implicit operator REFGUID(Guid* guid)
            {
                return *(REFGUID*)&guid;
            }

            public static implicit operator Guid*(REFGUID refiid)
            {
                return refiid.guid;
            }

            public static implicit operator IID*(REFGUID refiid)
            {
                return (IID*)refiid.guid;
            }

            public Guid Dereference()
            {
                return *guid;
            }
        }

        [NativeCppClass]
        [Guid("00000000-0000-0000-C000-000000000046")]
        public readonly struct IUnknown
        {
            [NativeCppClass]
            private readonly struct IUnknownVtbl
            {
                public readonly delegate* unmanaged[Stdcall]<IUnknown*, REFIID, void*, HRESULT> QueryInterface;
                public readonly delegate* unmanaged[Stdcall]<IUnknown*, ulong> AddRef;
                public readonly delegate* unmanaged[Stdcall]<IUnknown*, ulong> Release;
            }

            private readonly IUnknownVtbl* lpVtbl;

            public HRESULT QueryInterface(REFIID riid, void** ppvObject)
            {
                fixed (IUnknown* pThis = &this)
                {
                    return lpVtbl->QueryInterface(pThis, riid, ppvObject);
                }
            }

            public ulong AddRef()
            {
                fixed (IUnknown* pThis = &this)
                {
                    return lpVtbl->AddRef(pThis);
                }
            }

            public ulong Release()
            {
                fixed (IUnknown* pThis = &this)
                {
                    return lpVtbl->Release(pThis);
                }
            }
        }

        public struct HWND { }

        public struct HMONITOR { }

        public struct BOOL
        {
            int value;

            public static implicit operator bool(BOOL boolean)
            {
                return boolean.value == 1;
            }

            public static implicit operator BOOL(bool boolean)
            {
                return new BOOL { value = boolean ? 1 : 0 };
            }

            public static bool operator true(BOOL boolean)
            {
                return boolean.value == 1;
            }
            public static bool operator false(BOOL boolean)
            {
                return boolean.value == 1;
            }
        }

        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        /// <summary>
        /// <para>
        /// Contains window class information. It is used with the RegisterClassEx and GetClassInfoEx  functions.
        /// </para>
        /// <para>
        /// The WNDCLASSEX structure is similar to the WNDCLASS structure.There are two differences.WNDCLASSEX includes the cbSize member, which specifies the size of the structure, and the hIconSm member, which contains a handle to a small icon associated with the window class.
        /// </para>
        /// </summary>
        //public struct WNDCLASSEX 
        //{
        //    /// <summary>
        //    /// The size, in bytes, of this structure. Set this member to sizeof(WNDCLASSEX). Be sure to set this member before calling the GetClassInfoEx function.
        //    /// </summary>
        //    UINT cbSize;
        //    /// <summary>
        //    /// The class style(s). This member can be any combination of the Class Styles.
        //    /// </summary>
        //    UINT style;
        //    /// <summary>
        //    /// A pointer to the window procedure. You must use the CallWindowProc function to call the window procedure. For more information, see WindowProc.o
        //    /// </summary>
        //    WNDPROC lpfnWndProc;
        //    /// <summary>
        //    /// The number of extra bytes to allocate following the window-class structure. The system initializes the bytes to zero.
        //    /// </summary>
        //    int cbClsExtra;
        //    /// <summary>
        //    /// The number of extra bytes to allocate following the window instance. The system initializes the bytes to zero. If an application uses WNDCLASSEX to register a dialog box created by using the CLASS directive in the resource file, it must set this member to DLGWINDOWEXTRA.
        //    /// </summary>
        //    int cbWndExtra;
        //    /// <summary>
        //    /// A handle to the instance that contains the window procedure for the class.
        //    /// </summary>
        //    HINSTANCE hInstance;
        //    /// <summary>
        //    /// A handle to the class icon. This member must be a handle to an icon resource. If this member is NULL, the system provides a default icon.
        //    /// </summary>
        //    HICON hIcon;
        //    /// <summary>
        //    /// A handle to the class cursor. This member must be a handle to a cursor resource. If this member is NULL, an application must explicitly set the cursor shape whenever the mouse moves into the application's window.
        //    /// </summary>
        //    HCURSOR hCursor;
        //    /// <summary>
        //    /// A handle to the class background brush. This member can be a handle to the brush to be used for painting the background, or it can be a color value. A color value must be one of the following standard system colors (the value 1 must be added to the chosen color). If a color value is given, you must convert it to one of the following HBRUSH types:
        //    ///<list type="bullet">
        //    ///    <item>COLOR_ACTIVEBORDER    </item>
        //    ///    <item>COLOR_ACTIVECAPTION   </item>
        //    ///    <item>COLOR_APPWORKSPACE    </item>
        //    ///    <item>COLOR_BACKGROUND      </item>
        //    ///    <item>COLOR_BTNFACE         </item>
        //    ///    <item>COLOR_BTNSHADOW       </item>
        //    ///    <item>COLOR_BTNTEXT         </item>
        //    ///    <item>COLOR_CAPTIONTEXT     </item>
        //    ///    <item>COLOR_GRAYTEXT        </item>
        //    ///    <item>COLOR_HIGHLIGHT       </item>
        //    ///    <item>COLOR_HIGHLIGHTTEXT   </item>
        //    ///    <item>COLOR_INACTIVEBORDER  </item>
        //    ///    <item>COLOR_INACTIVECAPTION </item>
        //    ///    <item>COLOR_MENU            </item>
        //    ///    <item>COLOR_MENUTEXT        </item>
        //    ///    <item>COLOR_SCROLLBAR       </item>
        //    ///    <item>COLOR_WINDOW          </item>
        //    ///    <item>COLOR_WINDOWFRAME     </item>
        //    ///    <item>COLOR_WINDOWTEXT      </item>
        //    ///</list>
        //    /// <para>
        //    /// The system automatically deletes class background brushes when the class is unregistered by using UnregisterClass. An application should not delete these brushes.
        //    /// </para>
        //    /// <para>
        //    /// When this member is NULL, an application must paint its own background whenever it is requested to paint in its client area.To determine whether the background must be painted, an application can either process the WM_ERASEBKGND message or test the fErase member of the PAINTSTRUCT structure filled by the BeginPaint function.
        //    /// </para>
        //    /// </summary>
        //    void* /*HBRUSH*/ hbrBackground;
        //    LPCSTR lpszMenuName;
        //    LPCSTR lpszClassName;
        //    HICON hIconSm;
        //}

        public struct LPCSTR
        {
            public byte* NativePointer;

            public static implicit operator LPCSTR(string s)
            {
                return FromString(s);
            }

            public static LPCSTR FromString(string s)
            {
                LPCSTR result;

                result.NativePointer = (byte*)Marshal.StringToHGlobalAnsi($"{s}\u0000");

                return result;
            }

            public void Free()
            {
                Marshal.FreeHGlobal((IntPtr)this.NativePointer);
            }
        }
    }
}
