using System;
using System.Drawing;

namespace Singe3.Platforms
{
	/// <summary>
	/// Provides data for the <see cref="Platform.PositionChanged"/> event.
	/// </summary>
	public sealed class WindowPositionChangedEventArgs : EventArgs
	{
		/// <summary>
		/// Creates a new instance of the <see cref="WindowPositionChangedEventArgs"/> class.
		/// </summary>
		/// <param name="oldPosition">The position of the window before the event.</param>
		/// <param name="newPosition">The position of the window after the event.</param>
		public WindowPositionChangedEventArgs(Point oldPosition, Point newPosition)
		{
			OldPosition = oldPosition;
			NewPosition = newPosition;
		}

		/// <summary>
		/// The position of the window before the event.
		/// </summary>
		public Point OldPosition { get; private set; }
		
		/// <summary>
		/// The position of the window after the event.
		/// </summary>
		public Point NewPosition { get; private set; }

		/// <summary>
		/// A point representing window's change in position during the event. Returns <c>NewPosition - (Size)OldPosition</c>.
		/// </summary>
		public Point Delta => NewPosition - (Size)OldPosition;
	}
}
