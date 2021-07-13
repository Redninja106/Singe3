using System;
using System.Drawing;

namespace Singe3.Platforms
{
	/// <summary>
	/// Provides data for the <see cref="Platform.SizeChanged"/> event.
	/// </summary>
    public sealed class WindowSizeChangedEventArgs : EventArgs
    {
		/// <summary>
		/// Creates a new instance of the <see cref="WindowSizeChangedEventArgs"/> class.
		/// </summary>
		/// <param name="oldSize">The old size of the window from before the event.</param>
		/// <param name="newSize">The new size of the window after the event.</param>
		public WindowSizeChangedEventArgs(Size oldSize, Size newSize)
        {
			OldSize = oldSize;
            NewSize = newSize;
		}

		/// <summary>
		/// The old size of the window from before the event.
		/// </summary>
		public Size NewSize { get; private set; }

		/// <summary>
		/// The new size of the window after the event.
		/// </summary>
		public Size OldSize { get; private set; }

		/// <summary>
		/// A point representing window's change in size during the event. Returns <c>NewSize - OldSize</c>.
		/// </summary>
		public Size Delta => NewSize - OldSize;
	}
}
