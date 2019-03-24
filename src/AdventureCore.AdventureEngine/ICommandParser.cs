using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureCore.AdventureEngine
{
    public interface ICommandParser
    {
        event EventHandler<GameEvent> UserActionCompleted;
        void ParseCommand(string command, ILocation location); 
    }
}
