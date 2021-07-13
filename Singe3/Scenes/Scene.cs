using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singe3.Scenes
{
    public abstract class Scene : IGameEventHandler
    {
        public abstract void GenerateObjects();

        public virtual void OnDestroy(ApplicationContext context)
        {
        }

        public virtual void OnDraw(ApplicationContext context)
        {
        }

        public virtual void OnInitialize(ApplicationContext context)
        {
        }

        public virtual void OnUpdate(ApplicationContext context)
        {
        }
    }
}
