using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.AdventureEngine
{
    public class TokenResult
    {
        private List<string> words = new List<string>();

        public List<string> Words
        {
            get
            {
                return this.words;
            }
        }

        public string Verb {get;set;}
    }
}
