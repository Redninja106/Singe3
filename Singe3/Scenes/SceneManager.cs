using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singe3.Scenes
{
    class SceneManager : Game
    {
        private Scene currentScene;

        public SceneManager(Scene initialScene)
        {
            currentScene = initialScene;
        }

        public override void OnDestroy(ApplicationContext context)
        {
            currentScene.OnDestroy(context);
        }

        public override void OnDraw(ApplicationContext context)
        {
            currentScene.OnDraw(context);
        }

        public override void OnInitialize(ApplicationContext context)
        {
            currentScene.OnInitialize(context);
        }

        public override void OnUpdate(ApplicationContext context)
        {
            currentScene.OnUpdate(context);
        }
    }
}
