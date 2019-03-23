using AdventureCore.AdventureEngine;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTestAdventure
{
    public class MyUserInput : IUserInput
    {
        public string GetUserInput()
        {
            return Console.ReadLine();
        }
    }
}
