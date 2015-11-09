using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureEngine
{
    public class Game
    {
        private ILocation currentLocation;

        private List<ILocation> locations = new List<ILocation>();

        public List<ILocation> Locations
        {
            get
            {
                return this.locations;
            }
        }

        public ILocation Current
        {
            get
            {
                return this.currentLocation;
            }
        }

        public virtual void Start()
        {
        }

        protected virtual void SetLocation(ILocation location)
        {
            this.currentLocation = location;
        }
    }
}
