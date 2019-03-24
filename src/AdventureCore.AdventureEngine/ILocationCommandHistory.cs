using Adventure.AdventureEngine;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureCore.AdventureEngine
{
    public interface ILocationCommandHistory
    {
        void AddCommandToLocation(TokenResult tokenResult, ILocation location);

        IDictionary<ILocation, List<TokenResult>> GetCommandHistory();

        IEnumerable<TokenResult> GetCommandHistoryForLocation(ILocation location);

        IEnumerable<TokenResult> GetCommandHistoryForLocation(string verb, ILocation location);
    }
}
