using NUnit.Framework;
using Apples;

namespace ApplesTester
{
    [TestFixture]
    public class UnitTest1
    {
        Apple apple = new Apple();

        [Test]
        public void GetAppleTest()
        {
            string expected = "aple";
            string output = apple.GetApple();

            Assert.AreEqual(expected, output);
        }
    }
}
