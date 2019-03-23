using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.AdventureEngine
{
    public class LookAction
    {
        public void Do(TokenResult action, IList<IGameObject> objects)
        {
            foreach(var item in objects)
            {
                if (item.Is(action.Words))
                {
                    item.Look();
                }
            }
        }
    }
}
