using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.AdventureEngine
{
    public interface IGameObject
    {
        bool Is(List<string> list);

        void Look();
    }
}
