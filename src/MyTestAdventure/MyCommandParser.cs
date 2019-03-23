using Adventure.AdventureEngine;
using AdventureCore.AdventureEngine;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTestAdventure
{
    public class MyCommandParser : ICommandParser
    {
        private Tokenize _tokenizer = new Tokenize();

        public void ParseCommand(string command, ILocation location)
        {
            var t = _tokenizer.Parse(command.ToUpper());
        }
    }
}
