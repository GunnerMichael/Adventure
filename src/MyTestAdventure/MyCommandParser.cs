using Adventure.AdventureEngine;
using AdventureCore.AdventureEngine;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MyTestAdventure
{
    public class MyCommandParser : ICommandParser
    {
        public MyCommandParser(
            ILocationCommandHistory commandHistory
            )
        {
            this._commandHistory = commandHistory;
        }
        private ILocationCommandHistory _commandHistory;
        private Tokenize _tokenizer = new Tokenize();

        private EventHandler<GameEvent> actionCompleted;

        public event EventHandler<GameEvent> UserActionCompleted
        {
            add { actionCompleted += value; }
            remove { actionCompleted -= value; }
        }

        public void ParseCommand(string command, ILocation location)
        {
            var t = _tokenizer.Parse(command.ToUpper());

            _commandHistory.AddCommandToLocation(t, location);

            if (t.Verb == "LOOK")
            {
                var lookHistory = _commandHistory.GetCommandHistoryForLocation(t.Verb, location).ToList();

                if (lookHistory.Count > 1)
                {
                    actionCompleted.Invoke
                        (this, new GameEvent() { Message = "ALTLOOK" });
                }
                else
                {
                    actionCompleted.Invoke(this, new GameEvent() { Message = "LOOK" });

                }
         
            }
        }
    }
}
