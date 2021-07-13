using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singe3
{
    public abstract class Subsystem : IDisposable
    {
        /// <summary>
        /// The <see cref="Singe3.ApplicationContext"/> which this <see cref="Subsystem"/> belongs to.
        /// </summary>
        public ApplicationContext ApplicationContext { get; private set; }

        /// <summary>
        /// A list of <see cref="IDisposable"/> objects which will be automatically disposed with this subsystem
        /// </summary>
        private protected List<IDisposable> SubsystemResources { get; private set; }

        // for dispose pattern
        private bool disposedValue;

        public abstract SubsystemType GetSubsystemType();

        public Subsystem()
        {
            SubsystemResources = new List<IDisposable>();
        }

        internal void SetContext(ApplicationContext context)
        {
            this.ApplicationContext = context;
        }

        /// <summary>
        /// Called when 
        /// </summary>
        /// <param name="applicationContext">The calling <see cref="ApplicationContext"/>.</param>
        public virtual void OnAdded(ApplicationContext applicationContext)
        {
            if (applicationContext.IsRunning)
            {
                this.OnInitialize(applicationContext);
            }
        }

        /// <summary>
        /// Called when the subsystem is removed from it's <see cref="ApplicationContext"/>. <see cref="OnDestroy(ApplicationContext)"/> and <see cref="Dispose"/> may be called afterwards.
        /// </summary>
        /// <param name="applicationContext">The calling <see cref="ApplicationContext"/>.</param>
        public virtual void OnRemoved(ApplicationContext applicationContext)
        {

        }

        /// <summary>
        /// Called just before the render loop starts, just after all of the other Subsystems have been initialized.
        /// <para>The order in which this method is called is effected by the <see cref="CallBeforeAttribute"/> and <see cref="CallAfterAttribute"/> attributes.</para>
        /// </summary>
        /// <param name="context">The calling <see cref="ApplicationContext"/>.</param>
        public virtual void OnInitialize(ApplicationContext context)
        {

        }

        /// <summary>
        /// Called when the game is ready to render.
        /// <para>The order in which this method is called is effected by the <see cref="CallBeforeAttribute"/> and <see cref="CallAfterAttribute"/> attributes.</para>
        /// </summary>
        /// <param name="context">The calling <see cref="ApplicationContext"/>.</param>
        public virtual void OnDraw(ApplicationContext context)
        {

        }

        /// <summary>
        /// Called when the subsystem should perform any per-frame updates (i.e. taking input, moving objects, updating animations, or any other game logic).
        /// <para>The order in which this method is called is effected by the <see cref="CallBeforeAttribute"/> and <see cref="CallAfterAttribute"/> attributes.</para>
        /// </summary>
        /// <param name="context">The calling <see cref="ApplicationContext"/>.</param>
        public virtual void OnUpdate(ApplicationContext context)
        {

        }

        /// <summary>
        /// Called when the <see cref="Subsystem"/> should do any uninitialization before the this <see cref="Subsystem"/> and possibly others are disposed. This is the <see cref="Subsystem"/>'s last chance to do any uninitialization while other subsystems are present. 
        /// <para>Unlike <see cref="Dispose"/> the order in which this method is called is effected by the <see cref="CallBeforeAttribute"/> and <see cref="CallAfterAttribute"/> attributes.</para>
        /// <para>However, it is called in reverse order to <see cref="OnInitialize(ApplicationContext)"/> so that this subsystem's dependencies don't get destroyed before it. There are no such precautions for <see cref="Dispose"/>.</para>
        /// </summary>
        /// <param name="context">The calling <see cref="ApplicationContext"/>.</param>
        public virtual void OnDestroy(ApplicationContext context)
        {

        }

        /// <summary>
        /// Called when the <see cref="Subsystem"/> should dispose since the application is closing. There is no gaurantee for the order in which this method is called relative other subsystems. 
        /// <para>If overriding this method, make sure to call <c><see langword="base"/>.Dispose(disposing)</c> to assure that the elements of <see cref="SubsystemResources"/> are properly disposed.</para>
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    foreach (var resource in SubsystemResources)
                    {
                        resource?.Dispose();
                    }
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // for dispose pattern
        ~Subsystem()
        {
            Dispose(disposing: false);
        }

        /// <summary>
        /// Destroys the <see cref="Subsystem"/>.
        /// </summary>
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
