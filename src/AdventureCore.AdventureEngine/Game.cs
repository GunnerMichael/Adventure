using Adventure.AdventureEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureCore.AdventureEngine
{
    public class Game
    {
        private int _gameState;

        private ILocation currentLocation;

        private List<ILocation> locations = new List<ILocation>();
        private ILocationFactory _locationFactory;
        private ILocationDisplay _locationDisplay;
        private readonly IUserInput _userInput;
  
        private ICommandParser _parser;

        public Game(
            ILocationFactory locationFactory,
            ILocationDisplay locationDisplay,
            IUserInput userInput,
            ICommandParser parser)
        {
            _locationFactory = locationFactory;
            _locationDisplay = locationDisplay;
            this._userInput = userInput;
            this._parser = parser;
        }



        public List<ILocation> Locations
        {
            get
            {
                return locations;
            }
        }

        public ILocation Current
        {
            get
            {
                return currentLocation;
            }
        }

        public virtual void Start()
        {
            Locations.AddRange(_locationFactory.GetLocations());

            SetLocation(_locationFactory.GetStart());

            do
            {
                _locationDisplay.ShowLocation(Current);

               string command = _userInput.GetUserInput();

              




            } while (_gameState != -1);
        }

        protected virtual void SetLocation(ILocation location)
        {
            currentLocation = location;
        }
    }
}
