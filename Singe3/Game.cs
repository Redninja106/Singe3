using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singe3
{
    [SingleSubsystem]
    public abstract class Game : Subsystem
    {
        /// <summary>
        /// Called just before the render loop starts, just after all of the other Subsystems have been initialized.
        /// </summary>
        /// <param name="context">The calling <see cref="ApplicationContext"/>.</param>
        public abstract override void OnInitialize(ApplicationContext context);

        /// <summary>
        /// Called when the game should do it's rendering.
        /// </summary>
        /// <param name="context">The calling <see cref="ApplicationContext"/>.</param>
        public abstract override void OnDraw(ApplicationContext context);

        /// <summary>
        /// Called when the game should perform any per-frame updates (i.e. taking input, moving objects, updating animations, or any other game logic).
        /// </summary>
        /// <param name="context">The calling <see cref="ApplicationContext"/>.</param>
        public abstract override void OnUpdate(ApplicationContext context);

        /// <summary>
        /// Called when the game should do any uninitialization before the each subsystem is disposed.
        /// </summary>
        /// <param name="context">The calling <see cref="ApplicationContext"/>.</param>
        public abstract override void OnDestroy(ApplicationContext context);
    }
}
