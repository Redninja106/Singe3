using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Singe3
{
    public sealed class Dispatcher
    {
        // The ApplicationContext that owns this dispatcher.
        private readonly ApplicationContext context;
        
        // A tree of all of the subsystems, allowing events to be invoked on them in order.
        private readonly EventTree callTree;

        /// <summary>
        /// Creates a new instance of the <see cref="Dispatcher"/> class.
        /// </summary>
        /// <param name="context">The <see cref="ApplicationContext"/> which this dispatcher belongs to.</param>
        /// <param name="initialSubsystems">The initial subsystems to register for events.</param>
        internal Dispatcher(ApplicationContext context, IEnumerable<Subsystem> initialSubsystems)
        {
            this.context = context;
         
            this.callTree = new EventTree(initialSubsystems);
        }

        /// <summary>
        /// Called by the <see cref="ApplicationContext"/> to register a new subsystem for events from the dispatcher.
        /// </summary>
        /// <param name="subsystem">The new subsystem.</param>
        internal void OnSubsystemAdded(Subsystem subsystem)
        {
            callTree.Insert(subsystem);
        }
        
        /// <summary>
        /// Called by the <see cref="ApplicationContext"/> to unregister a new subsystem for events from the dispatcher. 
        /// </summary>
        /// <param name="subsystem"></param>
        internal void OnSubsystemRemoved(Subsystem subsystem)
        {
            callTree.Remove(subsystem);
        }

        /// <summary>
        /// Dispatches the <see cref="EventType.Initialize"/> event to the registered subsystems.
        /// </summary>
        internal void DispatchInitialize()
        {
            callTree.Invoke(EventType.Initialize);
        }

        /// <summary>
        /// Dispatches the <see cref="EventType.Destroy"/> event to the registered subsystems.
        /// </summary>
        internal void DispatchUpdate()
        {
            callTree.Invoke(EventType.Update);
        }

        /// <summary>
        /// Dispatches the <see cref="EventType.Draw"/> event to the registered subsystems.
        /// </summary>
        internal void DispatchDraw()
        {
            callTree.Invoke(EventType.Draw);
        }

        /// <summary>
        /// Dispatches the <see cref="EventType.Destroy"/> event to the registered subsystems.
        /// </summary>
        internal void DispatchDestroy()
        {
            callTree.Invoke(EventType.Destroy);
        }
    }
}
