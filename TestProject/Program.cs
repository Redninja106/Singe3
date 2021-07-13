using Singe3;
using Singe3.Resources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationContext.Create(new MyGame()).Run();
        }
    }

    [UpdateAfter(CoreSubsystem.Renderer)]
    class MyGame : Game
    {

        /// <inheritdoc/>
        public override void OnInitialize(ApplicationContext context)
        {
            var loader = context.ResourceLoader;

            foreach (var resource in loader.GetAllResourceHandles())
            {
                Console.WriteLine(resource.Path);

                Console.WriteLine(loader.Load(resource));
            }
        }

        /// <inheritdoc/>
        public override void OnUpdate(ApplicationContext context)
        {
        }

        /// <inheritdoc/>
        public override void OnDraw(ApplicationContext context)
        {
            context.Renderer.Clear(Color.Red);
        }
        
        /// <inheritdoc/>
        public override void OnDestroy(ApplicationContext context)
        {
        }
    }
}
