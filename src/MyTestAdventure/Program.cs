using AdventureCore.AdventureEngine;
using System;
using System.Collections.Generic;

namespace MyTestAdventure
{
    public class Program : Game
    {
        public Program(
            ILocationFactory factory,
            ILocationDisplay display,
            IUserInput userInput,
            ICommandParser commandParser) : base(factory, display,userInput, commandParser)
        {

        }
        static void Main(string[] args)
        {
            new Program(
                new MyLocationFactory()
                , new MyLocationDisplay()
                ,new MyUserInput()
                ,new MyCommandParser()).Start();
        }


    }
}
