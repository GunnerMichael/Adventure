using AdventureCore.AdventureEngine;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTestAdventure
{
    public class MyLocationDisplay : ILocationDisplay
    {
        public void ShowLocation(ILocation location, bool showAlternative)
        {
            if (showAlternative)
            {
                Console.WriteLine(location.AltDescription);
            }
            else
            {
                Console.WriteLine(location.LocationDescription);
            }
        }
    }
}
