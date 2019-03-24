using AdventureCore.AdventureEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureEngine
{
    public class Location : ILocation
    {
        public Location(string description, string altDescription)
        {
            this.locationDescription = description;
            this.altDescription = altDescription;
        }

        private string locationDescription;
        private string altDescription;


        public string AltDescription { get => altDescription; set => altDescription = value; }
        public string LocationDescription { get => locationDescription; set => locationDescription = value; }

    }
}
