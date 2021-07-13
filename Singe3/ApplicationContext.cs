using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Singe3.Platforms;
using Singe3.Rendering;
using Singe3.Resources;
using Singe3. Debugging;
using Singe3.Scenes;

namespace Singe3
{
    /// <summary>
    /// Main class for an application.
    /// </summary>
    public sealed class ApplicationContext : IDisposable
    {
        /// <summary>
        /// Returns this <see cref="ApplicationContext"/>'s <see cref="Singe3.AssemblyRegistry"/>.
        /// </summary>
        public AssemblyRegistry AssemblyRegistry { get; }

        /// <summary>
        /// Returns this <see cref="ApplicationContext"/>'s <see cref="Singe3.Dispatcher"/>
        /// </summary>
        public Dispatcher Dispatcher { get; }

        /// <summary>
        /// Returns the <see cref="Rendering.Renderer"/> subsystem.
        /// </summary>
        public Renderer Renderer => GetSubsystem<Renderer>();
        
        /// <summary>
        /// Returns the <see cref="Platforms.Platform"/>subsystem.
        /// </summary>
        public Platform Platform => GetSubsystem<Platform>();
        
        /// <summary>
        /// Returns the <see cref="Resources.ResourceLoader"/> subsystem.
        /// </summary>
        public ResourceLoader ResourceLoader => GetSubsystem<ResourceLoader>();
        
        /// <summary>
        /// Returns the <see cref="Debugging.GUI"/> subsystem.
        /// </summary>
        public GUI GUI => GetSubsystem<GUI>();
        
        /// <summary>
        /// returns the <see cref="Debugging.Debug"/> subsystem.
        /// </summary>
        public Debug Debug => GetSubsystem<Debug>();

        /// <summary>
        /// Returns a boolean which indicates if the application is running (i.e. the render loop is running).
        /// </summary>
        public bool IsRunning => initialized && !exiting;


        // main list of subsystems
        List<Subsystem> subsystems;

        // has the platform subsystem asked to close?
        private bool exiting;
        
        // has initialized been called?
        private bool initialized;

        // 
        private ApplicationContext(IEnumerable<Subsystem> subsystems)
        {
            this.subsystems = new List<Subsystem>(subsystems != null ? subsystems : Array.Empty<Subsystem>());

            AssemblyRegistry = new AssemblyRegistry();
            Dispatcher = new Dispatcher(this, this.subsystems);
        }

        /// <summary>
        /// Registers a new group of subsystems with the <see cref="ApplicationContext"/>. The <see cref="ApplicationContext"/> disposes the subsystems.
        /// </summary>
        /// <param name="subsystems"></param>
        public void AddSubsystem(params Subsystem[] subsystems)
        {
            AddSubsystem(subsystems.AsEnumerable());
        }

        /// <summary>
        /// Registers a new group of subsystems with the <see cref="ApplicationContext"/>. The <see cref="ApplicationContext"/> disposes the subsystems.
        /// </summary>
        /// <param name="subsystems"></param>
        public void AddSubsystem(IEnumerable<Subsystem> subsystems)
        {
            foreach (var subsystem in subsystems)
            {
                AddSubsystem(subsystem);
            }
        }

        /// <summary>
        /// Registers a new subsystem with the <see cref="ApplicationContext"/>. The <see cref="ApplicationContext"/> disposes the subsystem.
        /// </summary>
        /// <param name="subsystem"></param>
        public void AddSubsystem(Subsystem subsystem)
        {
            if (subsystem.GetType().GetCustomAttribute<SingleSubsystemAttribute>() != null)
            {
                if (subsystems.Contains(subsystem))
                    return;
            }

            subsystem.SetContext(this);

            subsystems.Add(subsystem);

            Dispatcher.OnSubsystemAdded(subsystem);

            if (this.initialized)
                subsystem.OnInitialize(this);
        }

        /// <summary>
        /// Registers all of the core subsystems to the <see cref="ApplicationContext"/>.
        /// </summary>

        /// <summary>
        /// Registers select core subsystems to the <see cref="ApplicationContext"/>
        /// </summary>
        /// <param name="coreSubsystems">Flags indicating which core subsystems should be added.</param>
        private void AddCoreSubsystems(bool debug)
        {
            var subsystems = new Subsystem[]
            {
                Platform.Create(),
                Renderer.Create(Platform.GetSupportedApis().OrderBy(api => (int)api).First()),
                ResourceLoader.Create(),
                GUI.Create(),
                Debug.Create(),
            };

            AddSubsystem(subsystems);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="subsystem"></param>
        /// <returns></returns>
        public bool HasSubsystem(Subsystem subsystem)
        {
            return subsystems.Contains(subsystem);
        }

        /// <summary>
        /// Returns a value indicating if a <see cref="Subsystem"/> of type <typeparamref name="T"/> is present on this <see cref="ApplicationContext"/>.
        /// </summary>
        /// <typeparam name="T">The type of subsystem to check for.</typeparam>
        public bool HasSubsystem<T>() where T : Subsystem
        {
            return HasSubsystem(typeof(T));
        }

        /// <summary>
        /// Returns a value indicating if a <see cref="Subsystem"/> of the provided type is present on this <see cref="ApplicationContext"/>.
        /// </summary>
        /// <param name="type">The type of subsystem to check for.</param>
        public bool HasSubsystem(Type type)
        {
            return subsystems.Any(s => type == s.GetType() | type.IsSubclassOf(s.GetType()));
        }

        /// <summary>
        /// Returns the <see cref="Subsystem"/> of the provided type if it is present on <see cref="ApplicationContext"/>
        /// </summary>
        /// <param name="type">The type of subsystem to get.</param>
        /// <returns>The subsystem if one of the provided type is present, otherwise null.</returns>
        public Subsystem GetSubsystem(Type type)
        {
            return this.subsystems.FirstOrDefault(s => type == s.GetType() || s.GetType().IsSubclassOf(type));
        }

        /// <summary>
        /// Returns the <see cref="Subsystem"/> of the provided type if it is present on <see cref="ApplicationContext"/>
        /// </summary>
        /// <typeparam name="T">The type of subsystem to get.</typeparam>
        /// <returns>The subsystem if one of the provided type is present, otherwise null.</returns>
        public T GetSubsystem<T>() where T : Subsystem
        {
            return (T)GetSubsystem(typeof(T));
        }

        /// <summary>
        /// Runs the application.
        /// </summary>
        public void Run()
        {
            Initialize();

            while (!this.IsRunning)
            {
                RunFrame();
            }

            foreach (var subsystem in this.subsystems)
            {
                subsystem.OnDestroy(this);
            }
        }
        
        /// <summary>
        /// Runs one frame of the application.
        /// </summary>
        public void RunFrame()
        {
            if (!initialized)
                Initialize();

            var windowManager = this.Platform ?? throw new Exception("Application Cannot run without a WindowManager Subsystem.");
            var renderer = this.Renderer ?? throw new Exception("Application Cannot run without a Renderer Subsystem.");
            var game = this.GetSubsystem<Game>() ?? throw new Exception("Application Cannot run without a Game Subsystem.");

            Time.Update();

            Platform.HandleEvents();

            //renderer.ClearState();
            //renderer.SetRenderTarget(renderer.GetWindowRenderTarget());

            //game.OnDraw(this);

            //game.OnUpdate(this);

            //renderer.GetRenderingOutput().Present(0);

            Dispatcher.DispatchDraw();


            Dispatcher.DispatchUpdate();
        }

        public void Dispose()
        {
            foreach (var subsystem in this.subsystems)
            {
                subsystem.Dispose();
            }
        }

        private void Initialize()
        {
            Dispatcher.DispatchInitialize();

            this.initialized = true;
        }

        public static ApplicationContext Create(ISceneFactory sceneFactory)
        {
            return Create(new SceneManager(sceneFactory));
        }

        /// <summary>
        /// Creates a new <see cref="ApplicationContext"/> with the provided initial subsystems, and adds and initializes the core subsystems.
        /// </summary>
        /// <param name="customSubsystems">A array containing the initial subsystems to add to the context.</param>
        /// <returns></returns>
        public static ApplicationContext Create(params Subsystem[] customSubsystems)
        {
            return Create(customSubsystems.AsEnumerable());
        }

        /// <summary>
        /// Creates a new <see cref="ApplicationContext"/> with the provided initial subsystems, and adds and initializes the core subsystems.
        /// </summary>
        /// <param name="debug"></param>
        /// <param name="customSubsystems">A array containing the initial subsystems to add to the context.</param>
        /// <returns></returns>
        public static ApplicationContext Create(bool debug, params Subsystem[] customSubsystems)
        {
            return Create(debug, customSubsystems.AsEnumerable());
        }

        /// <summary>
        /// Creates a new <see cref="ApplicationContext"/> with the provided initial subsystems, and adds and initializes the core subsystems.
        /// </summary>
        /// <param name="customSubsystems">A <see cref="IEnumerable{T}"/> containing the initial subsystems to add to the context.</param>
        /// <returns></returns>
        public static ApplicationContext Create(IEnumerable<Subsystem> customSubsystems)
        {
            return Create(false, customSubsystems);
        }

        /// <summary>
        /// Creates a new <see cref="ApplicationContext"/> with the provided initial subsystems, and optionally adds and initializes the core subsystems.
        /// </summary>
        /// <param name="debug"></param>
        /// <param name="customSubsystems">A <see cref="IEnumerable{T}"/> containing the initial subsystems to add to the context.</param>
        /// <returns>The newly created <see cref="AppContext"/>.</returns>
        private static ApplicationContext Create(bool debug, IEnumerable<Subsystem> customSubsystems)
        {
            var context = new ApplicationContext(null);

            context.AddCoreSubsystems(debug);

            foreach (var subsystem in customSubsystems)
            {
                context.AddSubsystem(subsystem);
            }

            return context;
        }

    }
}
