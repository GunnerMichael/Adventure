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
        private ILocationCommandHistory _commandHistory;
  
        private ICommandParser _parser;

        public Game(
            ILocationFactory locationFactory,
            ILocationDisplay locationDisplay,
            IUserInput userInput,
            ICommandParser parser,
            ILocationCommandHistory commandHistory)
        {
            _locationFactory = locationFactory;
            _locationDisplay = locationDisplay;
            this._userInput = userInput;
            this._parser = parser;
            this._commandHistory = commandHistory;
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

            _parser.UserActionCompleted += Parser_UserActionCompleted;


            _locationDisplay.ShowLocation(Current, showAlternative: false);

            string command = _userInput.GetUserInput();

            _parser.ParseCommand(command, currentLocation);

        }

        private void Parser_UserActionCompleted(object sender, GameEvent e)
        {
            if (e.Message == "LOOK")
            {
                _locationDisplay.ShowLocation(Current, showAlternative: false);
            }
            else if (e.Message == "ALTLOOK")
            {
                _locationDisplay.ShowLocation(Current, showAlternative: true);
            }

            string command = _userInput.GetUserInput();

            _parser.ParseCommand(command, currentLocation);
        }


        protected virtual void SetLocation(ILocation location)
        {
            currentLocation = location;
        }
    }
}
