using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventureEngine;
using Adventure.AdventureEngine;

namespace AdventureTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetRedSpoon()
        {
            Tokenize token = new Tokenize();

            var result = token.Parse("GET RED SPOON");

            Assert.AreEqual("GET", result.Verb);
        }

        [TestMethod]
        public void Look()
        {
            Tokenize token = new Tokenize();

            var result = token.Parse("LOOK");

            Assert.AreEqual("LOOK", result.Verb);
        }

        [TestMethod]
        public void LookAtRedSpoon()
        {
            Tokenize token = new Tokenize();

            var result = token.Parse("LOOK AT RED SPOON");

            Assert.AreEqual("LOOK", result.Verb);

            Assert.AreEqual(3, result.Words.Count);
        }


    }
}
