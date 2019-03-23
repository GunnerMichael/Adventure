using Adventure.AdventureEngine;
using NUnit.Framework;

namespace Tests
{
    public class TokenTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetRedSpoon()
        {
            Tokenize token = new Tokenize();

            var result = token.Parse("GET RED SPOON");

            Assert.AreEqual("GET", result.Verb);
        }

        [Test]
        public void Look()
        {
            Tokenize token = new Tokenize();

            var result = token.Parse("LOOK");

            Assert.AreEqual("LOOK", result.Verb);
        }

        [Test]
        public void LookAtRedSpoon()
        {
            Tokenize token = new Tokenize();

            var result = token.Parse("LOOK AT RED SPOON");

            Assert.AreEqual("LOOK", result.Verb);

            Assert.AreEqual(3, result.Words.Count);
        }

    }
}