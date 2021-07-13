using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Runtime.CompilerServices;
using Singe3.Rendering;
using Singe3.Rendering.Implementations.Direct3D11;
using Singe3.Platforms.Implementations.Windows.Util;
using Singe3.Rendering.Implementations.Direct3D11.Outputs;
using Windows.Win32.Graphics.Direct3D11;
using System.Runtime.InteropServices;
using Windows.Win32;
using Windows.Win32.System.SystemServices;
using Windows.Win32.UI.WindowsAndMessaging;
using static Windows.Win32.Constants;
using Windows.Win32.UI.DisplayDevices;

namespace Singe3.Platforms.Implementations.Windows
{
	internal sealed unsafe class HwndManager : Platform
	{
		private static readonly Dictionary<HWND, HwndManager> windowLookup = new();
		private static ushort atom;
		private static readonly string defWindowTitle = "hello world\u0000";
		private static bool initialized;
		
		private readonly InputDevice inputDevice;
		private HINSTANCE hInstance;

		private readonly HWND hwnd;

		public override event EventHandler<WindowSizeChangedEventArgs> SizeChanged;
		public override event EventHandler<WindowPositionChangedEventArgs> PositionChanged;
		public override event EventHandler<WindowTitleChangedEventArgs> TitleChanged;

		private Point position;
		private string title;
		private Size size;

		public unsafe HwndManager()
		{

			if (!initialized)
			{
				hInstance = Kernel32.GetModuleHandle(new PCWSTR(null));

				WNDCLASSEXW wndclass;
				delegate* unmanaged[Stdcall]<nint, uint, nuint, nint, int> wndProc = &WndProc;
				fixed (char* pName = "test")
				{
					wndclass = new WNDCLASSEXW()
					{
						lpszClassName = new PCWSTR(pName),
						hInstance = hInstance,
						lpfnWndProc = (delegate* unmanaged[Stdcall]<HWND, uint, WPARAM, LPARAM, LRESULT>)wndProc,
						cbSize = (uint)Unsafe.SizeOf<WNDCLASSEXW>(),
					};
				}

				atom = User32.RegisterClassEx(in wndclass);

				if (atom == 0)
				{
					throw new Exception();
				}

				initialized = true;
			}

			fixed (char* pWindowTitle = defWindowTitle, pClassName = "test")
				hwnd = User32.CreateWindowEx(0, new PCWSTR(pClassName), new PCWSTR(pWindowTitle), WINDOW_STYLE.WS_OVERLAPPEDWINDOW, CW_USEDEFAULT, CW_USEDEFAULT, 1200, 1200, default, default, hInstance, null);

			if (hwnd == IntPtr.Zero)
			{
				throw new Exception("Error creating window!");
			}

			inputDevice = new InputDevice(this);
			windowLookup.Add(hwnd, this);

			User32.ShowWindow(hwnd, SHOW_WINDOW_CMD.SW_SHOW);
		}

		private static Key VkToKey(uint vk)
		{
			switch (vk)
			{
				case VK_LBUTTON:
					return Key.LeftMouse;
				case VK_RBUTTON:
					return Key.RightMouse;
				case VK_MBUTTON:
					return Key.MiddleMouse;
				case VK_XBUTTON1:
					return Key.MouseX1;
				case VK_XBUTTON2:
					return Key.MouseX2;
				case VK_BACK:
					return Key.Backspace;
				case VK_TAB:
					return Key.Tab;
				case VK_RETURN:
					return Key.Enter;
				case VK_SHIFT:
					return Key.LShift;
				case VK_CONTROL:
					return Key.LCtrl;
				case VK_MENU:
					return Key.Menu;
				case VK_CAPITAL:
					return Key.CapsLock;
				case VK_ESCAPE:
					return Key.Esc;
				case VK_SPACE:
					return Key.Space;
				case VK_PRIOR:
					return Key.PageUp;
				case VK_NEXT:
					return Key.PageDown;
				case VK_END:
					return Key.End;
				case VK_HOME:
					return Key.Home;
				case VK_LEFT:
					return Key.LeftArrow;
				case VK_UP:
					return Key.UpArrow;
				case VK_RIGHT:
					return Key.RightArrow;
				case VK_DOWN:
					return Key.DownArrow;
				case VK_INSERT:
					return Key.Insert;
				case VK_DELETE:
					return Key.Delete;
				case 0x30:
					return Key.Key0;
				case 0x31:
					return Key.Key1;
				case 0x32:
					return Key.Key2;
				case 0x33:
					return Key.Key3;
				case 0x34:
					return Key.Key4;
				case 0x35:
					return Key.Key5;
				case 0x36:
					return Key.Key6;
				case 0x37:
					return Key.Key7;
				case 0x38:
					return Key.Key8;
				case 0x39:
					return Key.Key9;
				case 0x41:
					return Key.A;
				case 0x42:
					return Key.B;
				case 0x43:
					return Key.C;
				case 0x44:
					return Key.D;
				case 0x45:
					return Key.E;
				case 0x46:
					return Key.F;
				case 0x47:
					return Key.G;
				case 0x48:
					return Key.H;
				case 0x49:
					return Key.I;
				case 0x4A:
					return Key.J;
				case 0x4B:
					return Key.K;
				case 0x4C:
					return Key.L;
				case 0x4D:
					return Key.M;
				case 0x4E:
					return Key.N;
				case 0x4F:
					return Key.O;
				case 0x50:
					return Key.P;
				case 0x51:
					return Key.Q;
				case 0x52:
					return Key.R;
				case 0x53:
					return Key.S;
				case 0x54:
					return Key.T;
				case 0x55:
					return Key.U;
				case 0x56:
					return Key.V;
				case 0x57:
					return Key.W;
				case 0x58:
					return Key.X;
				case 0x59:
					return Key.Y;
				case 0x5A:
					return Key.Z;
				case VK_LWIN:
					return Key.LMeta;
				case VK_RWIN:
					return Key.RMeta;
				case VK_NUMPAD0:
					return Key.Numpad0;
				case VK_NUMPAD1:
					return Key.Numpad1;
				case VK_NUMPAD2:
					return Key.Numpad2;
				case VK_NUMPAD3:
					return Key.Numpad3;
				case VK_NUMPAD4:
					return Key.Numpad4;
				case VK_NUMPAD5:
					return Key.Numpad5;
				case VK_NUMPAD6:
					return Key.Numpad6;
				case VK_NUMPAD7:
					return Key.Numpad7;
				case VK_NUMPAD8:
					return Key.Numpad8;
				case VK_NUMPAD9:
					return Key.Numpad9;
				//case VK_MULTIPLY:
				//    return Key.;
				case VK_ADD:
					return Key.Plus;
				case VK_SUBTRACT:
					return Key.Minus;
				case VK_DECIMAL:
					return Key.Period;
				case VK_DIVIDE:
					return Key.Slash;
				case VK_F1:
					return Key.F1;
				case VK_F2:
					return Key.F2;
				case VK_F3:
					return Key.F3;
				case VK_F4:
					return Key.F4;
				case VK_F5:
					return Key.F5;
				case VK_F6:
					return Key.F6;
				case VK_F7:
					return Key.F7;
				case VK_F8:
					return Key.F8;
				case VK_F9:
					return Key.F9;
				case VK_F10:
					return Key.F10;
				case VK_F11:
					return Key.F11;
				case VK_F12:
					return Key.F12;
				//case VK_OEM_NEC_EQUAL:
				//    return Key.eqals
				case VK_LSHIFT:
					return Key.LShift;
				case VK_RSHIFT:
					return Key.RShift;
				case VK_LCONTROL:
					return Key.LCtrl;
				case VK_RCONTROL:
					return Key.RCtrl;
				case VK_OEM_1:
					return Key.Semicolon;
				case VK_OEM_PLUS:
					return Key.Plus;
				case VK_OEM_COMMA:
					return Key.Comma;
				case VK_OEM_MINUS:
					return Key.Minus;
				case VK_OEM_PERIOD:
					return Key.Period;
				case VK_OEM_2:
					return Key.Slash;
				case VK_OEM_3:
					return Key.Tilde;
				case VK_OEM_4:
					return Key.LBracket;
				case VK_OEM_5:
					return Key.BackSlash;
				case VK_OEM_6:
					return Key.RBracket;
				case VK_OEM_7:
					return Key.Apostrophe;
				case VK_OEM_8:
					return Key.Minus;
				default:
					return Key.Unknown;
			}
		}

		[UnmanagedCallersOnly(CallConvs = new[]{ typeof(CallConvStdcall) })]
		private static unsafe int WndProc(nint hwnd, uint msg, nuint wParam, nint lParam)
		{
			HwndManager window = null;
			if (windowLookup.ContainsKey((HWND)hwnd))
			{
				window = windowLookup[(HWND)hwnd];
			}
			var wUnion = new Union(wParam);
			var lUnion = new Union(lParam);
			
			switch (msg)
			{
				//case WM_SIZING:
				//    RECT* rp = (RECT*)lParam.Value;
				//    window.SizeChanged?.Invoke(window, new WindowSizeChangedEventArgs(new Size(rp->right - rp->left, rp->bottom - rp->top)));
				//    return (LRESULT)1;
				case WM_CHAR:
					window.inputDevice.OnKeyTyped((char)(int)wParam);
					break;
				case WM_MOUSEMOVE:
					window.inputDevice.OnMouseMove(new System.Numerics.Vector2(lUnion.low, lUnion.high));
					break;
				case WM_LBUTTONDOWN:
					window.inputDevice.OnKeyDown(Key.LeftMouse);
					break;
				case WM_LBUTTONUP:
					window.inputDevice.OnKeyUp(Key.LeftMouse);
					break;
				case WM_RBUTTONDOWN:
					window.inputDevice.OnKeyDown(Key.RightMouse);
					break;
				case WM_RBUTTONUP:
					window.inputDevice.OnKeyUp(Key.RightMouse);
					break;
				case WM_MOUSEWHEEL:
					window.inputDevice.OnScroll(wUnion.high / 120);
					break;
				case WM_XBUTTONDOWN:
					window.inputDevice.OnKeyDown(wUnion.high == 1 ? Key.MouseX1 : Key.MouseX2);
					break;
				case WM_XBUTTONUP:
					window.inputDevice.OnKeyUp(wUnion.high == 1 ? Key.MouseX1 : Key.MouseX2);
					break;
				case WM_MBUTTONDOWN:
					window.inputDevice.OnKeyDown(Key.MiddleMouse);
					break;
				case WM_MBUTTONUP:
					window.inputDevice.OnKeyUp(Key.MiddleMouse);
					break;
				case WM_SYSCOMMAND:
					//switch ((SysCommands)(int)wParam)
					//{
					//    case SysCommands.SC_MAXIMIZE:
					//        WINDOWINFO info = new WINDOWINFO();
					//        if (GetWindowInfo(hwnd, ref info))
					//        {
					//            window.SizeChanged?.Invoke(window, new SizeChangedEventArgs(new Size(info.rcWindow.right - info.rcWindow.left, info.rcWindow.bottom - info.rcWindow.top)));
					//        }
					//        break;
					//    default:
					//        break;
					//}
					break;
				case WM_SIZE:
					var oldSize = window.size;
					window.size = new Size(lUnion.low, lUnion.high);
					window.SizeChanged?.Invoke(window, new WindowSizeChangedEventArgs(oldSize, window.size));
					break;
				case WM_KEYDOWN:
					window.inputDevice.OnKeyDown(VkToKey((uint)wParam));
					break;
				case WM_KEYUP:
					window.inputDevice.OnKeyUp(VkToKey((uint)wParam));
					break;
				case WM_SETTEXT:
					var oldTitle = window.title;
					window.title = Marshal.PtrToStringAnsi(lParam);
					window.TitleChanged?.Invoke(window, new WindowTitleChangedEventArgs(oldTitle, window.title));
					break;
				case WM_MOVE:
					var oldPos = window.position;
					window.position = new Point(lUnion.low, lUnion.high);
					window.PositionChanged?.Invoke(window, new WindowPositionChangedEventArgs(oldPos, window.position));
					break;
			}

			return User32.DefWindowProc((HWND)hwnd, msg, wParam, lParam);
		}

		protected override void Dispose(bool disposing)
		{
			User32.DestroyWindow(hwnd);
			Kernel32.FreeLibrary(hInstance);
		}

		public override DisplayInformation[] GetDisplayInformation()
		{
			return null;
		}

		public override bool RequestPositionChange(Point newPosition)
		{
			return User32.SetWindowPos(hwnd, default, newPosition.X, newPosition.Y, 0, 0, SET_WINDOW_POS_FLAGS.SWP_NOZORDER | SET_WINDOW_POS_FLAGS.SWP_NOSIZE);
		}

		public override bool RequestSizeChange(Size newSize)
		{
			return User32.SetWindowPos(hwnd, default, 0, 0, newSize.Width, newSize.Height, SET_WINDOW_POS_FLAGS.SWP_NOMOVE | SET_WINDOW_POS_FLAGS.SWP_NOZORDER);
		}

		public override void SetWindowMode(WindowMode mode)
		{
		}

		public override bool RequestTitleChange(string title)
		{
			return User32.SetWindowText(hwnd, title);
		}

		public override unsafe void HandleEvents()
		{
			MSG msg;
			while (User32.PeekMessage(&msg, hwnd, 0, 0, PEEK_MESSAGE_REMOVE_TYPE.PM_REMOVE))
			{
				User32.TranslateMessage(&msg);
				User32.DispatchMessage(&msg);
			}
		}

		public override IRenderingOutput CreateOutput(Renderer renderer)
		{
			switch(renderer.Api)
			{
				case GraphicsApi.Direct3D11:
					return new D3D11HwndOutput((D3D11Renderer)renderer, this);
				default:
					throw new Exception("unsupported rendering api");
			}
		}

		public override GraphicsApi[] GetSupportedApis()
		{
			return new[] { GraphicsApi.Direct3D11 };
		}

		public HWND GetHwnd()
		{
			return this.hwnd;
		}

		public override Size GetSize()
		{
			return this.size;
		}

		public override Point GetPosition()
		{
			return this.position;
		}

		public override string GetTitle()
		{
			return this.title;
		}

		public override InputDevice CreateInputDevice()
		{
			return inputDevice;
		}
	}
}
