using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Singe3
{
    /// <summary>
    /// Handles invocation order for subsystem events.
    /// </summary>
    internal sealed class EventTree
    {
        // all of the nodes present in the tree.
        private List<EventTreeNode> allNodes;

        // the root nodes of the tree. These are the nodes which have no dependencies.
        private List<EventTreeNode> rootNodes;

        // the leaf nodes of the tree. These are the nodes which have no dependents.
        private List<EventTreeNode> leafNodes;

        /// <summary>
        /// Creates a new instance of the <see cref="EventTree"/> class.
        /// </summary>
        /// <param name="subsystems">The subsystems which should be initially present in the tree.</param>
        public EventTree(IEnumerable<Subsystem> subsystems)
        {
            Build(subsystems);
        }

        /// <summary>
        /// Invokes the entire tree in a normal order.
        /// </summary>
        /// <param name="eventType">The type of event to invoke.</param>
        public void Invoke(EventType eventType)
        {
            foreach (var root in rootNodes)
            {
                root.Invoke(eventType);
            }
        }

        /// <summary>
        /// Invokes the entire tree in reverse, starting from the leaves and ending with the roots.
        /// </summary>
        /// <param name="eventType"></param>
        public void InvokeReverse(EventType eventType)
        {
            foreach (var leaf in leafNodes)
            {
                leaf.InvokeReverse(eventType);
            }
        }

        // Sets the Invoked property to false for every node.
        private void ResetInvokedNodes()
        {
            foreach (var node in allNodes)
            {
                node.Invoked = false;
            }
        }

        /// <summary>
        /// Inserts a new node into the tree.
        /// </summary>
        /// <param name="subsystem">The subsystem to insert a node representing.</param>
        public void Insert(Subsystem subsystem)
        {
            Insert(subsystem, true);
        }

        /// <summary>
        /// Inserts a new node into the tree.
        /// </summary>
        /// <param name="subsystem">The subsystem to insert a node representing.</param>
        /// <param name="updateRoots">Whether or not to update the leaves and roots of the tree. This is used internally when a large amount of nodes are added at once, for example the initial nodes when the tree is created.</param>
        private void Insert(Subsystem subsystem, bool updateRoots)
        {
            // throw if this subsytem is already present.
            if (allNodes.Any(node => node.Subsystem == subsystem))
                throw new Exception("already exists");

            // get node for the subsystem.
            var node = GetOrCreateNode(subsystem);

            // get dependencies for the node
            node.Dependencies = GetDependencies(subsystem);

            // register this node as a depende
            foreach (var dependency in node.Dependencies)
            {
                dependency.Dependents.Add(node);
            }

            // get new node's dependents
            node.Dependents = GetDependents(subsystem);

            // update roots and leaves
            if (updateRoots)
            {
                this.UpdateRoots();
            }
        }

        /// <summary>
        /// Removes a subsystem from the tree.
        /// </summary>
        /// <param name="subsystem">The subsystem to remove.</param>
        public void Remove(Subsystem subsystem)
        {
            // get subsystem
            var targetnode = GetOrCreateNode(subsystem);

            // remove nodes
            allNodes.Remove(targetnode);

            // remove from dependencies and dependents
            targetnode.Dependencies.ForEach(node => node.Dependents.Remove(targetnode));
            targetnode.Dependents.ForEach(node => node.Dependencies.Remove(targetnode));

            // update roots to not include the node, it it was possibly one
            UpdateRoots();
        }

        /// <summary>
        /// Initially builds the tree.
        /// </summary>
        /// <param name="subsystems"></param>
        private void Build(IEnumerable<Subsystem> subsystems)
        {
            allNodes = new List<EventTreeNode>();
            rootNodes = new List<EventTreeNode>();

            // insert every node
            foreach (var s in subsystems)
            {
                Insert(s, false);
            }

            UpdateRoots();
        }

        /// <summary>
        /// Returns the dependencies of a node within the tree.
        /// </summary>
        /// <param name="subsystem">The subsystem to get the dependencies of.</param>
        /// <returns></returns>
        private List<EventTreeNode> GetDependencies(Subsystem subsystem)
        {
            var attributes = subsystem.GetType().GetCustomAttributes<CallAfterAttribute>();

            var types = attributes.SelectMany(attr => attr.Subsystems);

            return types.SelectMany(t => GetNodesForType(t)).ToList();
        }

        private List<EventTreeNode> GetDependents(Subsystem subsystem)
        {
            return allNodes.Where(node => GetDependencies(node.Subsystem).Any(node => node.Subsystem == subsystem)).ToList();
        }

        private IEnumerable<EventTreeNode> GetNodesForType(Type t)
        {
            var res = allNodes.Where(node => node.Subsystem.GetType() == t || node.Subsystem.GetType().IsSubclassOf(t));
            return res;
        }

        private void UpdateRoots()
        {
            rootNodes.Clear();
            rootNodes.AddRange(allNodes.Where(node => !node.Dependencies.Any()));

            leafNodes.Clear();
            leafNodes.AddRange(allNodes.Where(node => !node.Dependents.Any()));
        }

        private EventTreeNode GetOrCreateNode(Subsystem subsystem)
        {
            if (allNodes.Any(node => node.Subsystem == subsystem))
            {
                return allNodes.First(node => node.Subsystem == subsystem);
            }

            var newNode = new EventTreeNode(subsystem);
            allNodes.Add(newNode);
            return newNode;
        }

        // a node in the event tree
        private sealed class EventTreeNode
        {
            /// <summary>
            /// Gets the dependencies for this node, which are the nodes that need to be invoked after this one.
            /// </summary>
            public List<EventTreeNode> Dependencies { get; set; }

            /// <summary>
            /// Returns a value which indicates if this event has been invoked within the current tree invocation.
            /// </summary>
            public bool Invoked { get; set; }

            /// <summary>
            /// Returns the subsystem which this node represents.
            /// </summary>
            public Subsystem Subsystem { get; set; }

            /// <summary>
            /// Gets the dependents for this node, which are the nodes that need to be invoked after this one.
            /// </summary>
            public List<EventTreeNode> Dependents { get; set; }

            /// <summary>
            /// Creates a new instance of the <see cref="EventTreeNode"/> class.
            /// </summary>
            /// <param name="subsystem">The subsystem which this node represents.</param>
            public EventTreeNode(Subsystem subsystem)
            {
                this.Subsystem = subsystem;
            }

            /// <summary>
            /// Invokes this node and any ready dependents.
            /// </summary>
            /// <param name="eventType"></param>
            public void Invoke(EventType eventType)
            {
                InvokeCore(eventType, node => node.Dependencies, node => node.Dependents);
            }

            /// <summary>
            /// Invokes this node and any ready dependencies, since the tree is being invoked in reverse order.
            /// </summary>
            /// <param name="eventType"></param>
            public void InvokeReverse(EventType eventType)
            {
                InvokeCore(eventType, node => node.Dependents, node => node.Dependencies);
            }

            // invokes this event tree node and any ready dependents, using Func<T> delegates to get the dependencies and dependents for node.
            private void InvokeCore(EventType eventType, Func<EventTreeNode, List<EventTreeNode>> getDependencies, Func<EventTreeNode, List<EventTreeNode>> getDependents)
            {
                // if a dependencies has not been invoked, something has gone wrong.
                foreach (var dep in getDependencies(this))
                {
                    if (!dep.Invoked)
                        throw new Exception();
                }

                // call the proper method for the subsystem.
                switch (eventType)
                {
                    case EventType.Initialize:
                        Subsystem.OnInitialize(Subsystem.ApplicationContext);
                        break;
                    case EventType.Draw:
                        Subsystem.OnDraw(Subsystem.ApplicationContext);
                        break;
                    case EventType.Update:
                        Subsystem.OnUpdate(Subsystem.ApplicationContext);
                        break;
                    case EventType.Destroy:
                        Subsystem.OnDestroy(Subsystem.ApplicationContext);
                        break;
                    default:
                        throw new Exception("Unrecognized event type.");
                };

                Invoked = true;

                foreach (var dependent in getDependents(this))
                {
                    // if the dependent is not ready (i.e. not all of it's dependencies have been invoked), don't invoke it.
                    if (getDependencies(dependent).Any(dep => !dep.Invoked))
                        continue;

                    // if it hasn't already been invoked, invoke it.
                    if (!dependent.Invoked)
                        dependent.Invoke(eventType);
                }
            }
        }
    }
}
