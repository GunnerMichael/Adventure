using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureEngine
{
    public class Location : ILocation
    {
        public Location(string description)
        {
            this.locationDescription = description;
        }

        private string locationDescription;
        public string LocationDescription
        {
            get
            {
                return this.locationDescription;
            }
        }

        public virtual void Look()
        {

        }
    }
}
