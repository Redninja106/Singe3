using System;

namespace Singe3
{
    public sealed class ScrollEventArgs : EventArgs
    {
        public int Delta { get; }

        public ScrollEventArgs(int delta)
        {
            this.Delta = delta;
        }
    }
}
