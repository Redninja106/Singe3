using System;
using System.Collections.Generic;
using System.Text;

namespace Singe3.Platforms
{
    public sealed class CharEventArgs : EventArgs
    {
        public CharEventArgs(char character)
        {
            Character = character;
        }

        public char Character { get; private set; }
    }
}
