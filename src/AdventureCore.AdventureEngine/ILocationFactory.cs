using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureCore.AdventureEngine
{
    public interface ILocationFactory
    {
        IEnumerable<ILocation> GetLocations();
        ILocation GetStart();
    }
}
