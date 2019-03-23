using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureCore.AdventureEngine
{
    public interface ICommandParser
    {
        void ParseCommand(string command, ILocation location); 
    }
}
