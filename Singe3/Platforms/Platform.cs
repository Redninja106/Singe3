using Singe3.Platforms.Implementations.Windows;
using Singe3.Rendering;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Singe3.Platforms
{
    [SingleSubsystem]
    public abstract class Platform : Subsystem, IRenderingOutputFactory
    {
        #region statics
        public static Platform Create()
        {
            return new HwndManager();
        }
        #endregion

        public abstract void HandleEvents();

        public abstract void SetWindowMode(WindowMode mode);

        public abstract bool RequestSizeChange(Size newSize);
        public abstract bool RequestPositionChange(Point newPosition);
        public abstract bool RequestTitleChange(string title);

        public abstract Size GetSize();
        public abstract Point GetPosition();
        public abstract string GetTitle();

        public abstract InputDevice CreateInputDevice();

        public abstract IRenderingOutput CreateOutput(Renderer renderer);
        public abstract GraphicsApi[] GetSupportedApis();

        public abstract DisplayInformation[] GetDisplayInformation();

        public abstract event EventHandler<WindowSizeChangedEventArgs> SizeChanged;
        public abstract event EventHandler<WindowPositionChangedEventArgs> PositionChanged;
        public abstract event EventHandler<WindowTitleChangedEventArgs> TitleChanged;
    }
}
