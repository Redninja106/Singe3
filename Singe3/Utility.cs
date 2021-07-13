using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Singe3.Rendering;
using Singe3.Debugging;
using Singe3.Resources;
using Singe3.Platforms;

namespace Singe3
{
    internal static class Utility
    {
        public static Vector4 ColorToVectorARGB(Color color)
        {
            return new Vector4(color.A / 255f, color.R / 255f, color.G / 255f, color.B / 255f);
        }

        public static Vector4 ColorToVectorRGBA(Color color)
        {
            return new Vector4(color.R / 255f, color.G / 255f, color.B / 255f, color.A / 255f);
        }

        public static Type[] CoreSubsystemToTypes(CoreSubsystem coreSubsystem)
        {
            var result = new List<Type>();

            if (coreSubsystem.HasFlag(CoreSubsystem.Renderer))
                result.Add(typeof(Renderer));
            if (coreSubsystem.HasFlag(CoreSubsystem.Platform))
                result.Add(typeof(Platform));
            if (coreSubsystem.HasFlag(CoreSubsystem.ResourceLoader))
                result.Add(typeof(ResourceLoader));
            if (coreSubsystem.HasFlag(CoreSubsystem.GUI))
                result.Add(typeof(GUI));
            if (coreSubsystem.HasFlag(CoreSubsystem.Debug))
                result.Add(typeof(Debug));

            return result.ToArray();
        }

        public static Vector2 ToVector2(this Size size)
        {
            return new Vector2(size.Width, size.Height);
        }
    }
}
