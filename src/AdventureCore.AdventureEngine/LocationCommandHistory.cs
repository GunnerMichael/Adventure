using System;
using System.Collections.Generic;
using System.Text;
using Adventure.AdventureEngine;
using System.Linq;

namespace AdventureCore.AdventureEngine
{
    public class LocationCommandHistory : ILocationCommandHistory
    {
        private IDictionary<ILocation, List<TokenResult>> commands = new Dictionary<ILocation, List<TokenResult>>();

        public void AddCommandToLocation(TokenResult tokenResult, ILocation location)
        {
            if (commands.ContainsKey(location))
            {
                commands[location].Add(tokenResult);
            }
            else
            {
                commands[location] = new List<TokenResult>() { tokenResult };
            }
        }

        public IDictionary<ILocation, List<TokenResult>> GetCommandHistory()
        {
            return commands;
        }

        public IEnumerable<TokenResult> GetCommandHistoryForLocation(ILocation location)
        {
            return commands[location];
        }

        public IEnumerable<TokenResult> GetCommandHistoryForLocation(string verb, ILocation location)
        {
            return from x in commands[location]
                   where x.Verb == verb.ToUpper()
                   select x;
        }

       
    }
}
