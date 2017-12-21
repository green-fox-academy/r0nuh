using NUnit.Framework;
using System.Collections.Generic;
using UniqueChars;

namespace UniqueCharsTester
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestUniqueCharacters()
        {
            var output = Program.UniqueCharacters("alma");
            char expect = 'l';

            Assert.Contains(expect, output);
        }
    }
}
