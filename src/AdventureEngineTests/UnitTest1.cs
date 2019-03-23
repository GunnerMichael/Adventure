using Adventure.AdventureEngine;
using System;
using Xunit;

namespace AdventureEngineTests
{
    public class UnitTest1
    {
        [Fact]
        public void GetRedSpoon()
        {
            Tokenize token = new Tokenize();

            var result = token.Parse("GET RED SPOON");

            Assert.Matches("GET", result.Verb);
        }

        [Fact]
        public void Look()
        {
            Tokenize token = new Tokenize();

            var result = token.Parse("LOOK");

            Assert.Matches("LOOK", result.Verb);
        }

        [Fact]
        public void LookAtRedSpoon()
        {
            Tokenize token = new Tokenize();

            var result = token.Parse("LOOK AT RED SPOON");

            Assert.Matches("LOOK", result.Verb);

            Assert.Matches(3, result.Words.Count);
        }

    }
}
