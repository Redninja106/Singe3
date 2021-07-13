using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singe3
{
    public interface IGameEventHandler
    {
        void OnInitialize(ApplicationContext context);
        void OnDraw(ApplicationContext context);
        void OnUpdate(ApplicationContext context);
        void OnDestroy(ApplicationContext context);
    }
}
