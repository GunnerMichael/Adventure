using AdventureCore.AdventureEngine;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTestAdventure
{
    public class MyGame : Game
    {
        public MyGame(
            ILocationFactory factory,
                ILocationDisplay display,
                IUserInput userInput,
                ICommandParser commandParser,
                ILocationCommandHistory commandHistory) :
                base(factory, display, userInput, commandParser, commandHistory)
        {

        }

        public override void Start()
        {
            base.Start();
        }
    }
}
