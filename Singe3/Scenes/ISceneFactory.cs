using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singe3.Scenes
{
    public interface ISceneFactory
    {
        public Scene NextScene();
    }
}
