using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.AdventureEngine
{
    public class Tokenize
    {
        public TokenResult Parse(string text)
        {
            TokenResult result = new TokenResult();

            string[] tokens = text.Trim().Split(' ');

            if (tokens.Length >= 1)
            {
                result.Verb = tokens[0];
            }

            if (tokens.Length > 1)
            {
                for (int x = 1; x < tokens.Length; x++)
                {
                    result.Words.Add(tokens[x]);
                }
            }

            return result;
        }
    }
}
