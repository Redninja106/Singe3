using System;
using System.Collections.Generic;
using System.Text;

namespace Singe3.Platforms
{
	/// <summary>
	/// Provides data for the <see cref="Platform.TitleChanged"/> event.
	/// </summary>
	public sealed class WindowTitleChangedEventArgs : EventArgs
	{
		/// <summary>
		/// Creates a new instance of the <see cref="WindowTitleChangedEventArgs"/> class.
		/// </summary>
		/// <param name="newTitle">The new title of the window after the event.</param>
		/// <param name="oldTitle">The old title of the window from before the event.</param>
		public WindowTitleChangedEventArgs(string oldTitle, string newTitle)
		{
			NewTitle = newTitle;
			OldTitle = oldTitle;
		}

		/// <summary>
		/// The old title of the window from before the event.
		/// </summary>
		public string OldTitle { get; private set; }

		/// <summary>
		/// The new title of the window after the event.
		/// </summary>
		public string NewTitle { get; private set; }
	}
}
