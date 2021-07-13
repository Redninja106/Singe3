using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singe3.Scenes
{
    public abstract class SceneFactoryBase : ISceneFactory
    {
        private Queue<Scene> scenes;
        protected abstract IEnumerable<Scene> GetScenes();

        public Scene NextScene()
        {
            return scenes.Dequeue();
        }

        protected SceneFactoryBase()
        {
            scenes = new Queue<Scene>(scenes);
        }

        public void RegisterNextScene(Scene scene)
        {
            scenes.Enqueue(scene);
        }
    }
}
