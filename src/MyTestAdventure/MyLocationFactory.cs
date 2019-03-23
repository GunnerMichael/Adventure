using AdventureCore.AdventureEngine;
using AdventureEngine;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTestAdventure
{
    public class MyLocationFactory : ILocationFactory
    {
        private List<ILocation> locations = new List<ILocation>();
        public IEnumerable<ILocation> GetLocations()
        {
            locations.Add(new Location("You are in a dark room"));
            return locations; 
        }

        public ILocation GetStart()
        {
            return locations[0];
        }
    }
}
