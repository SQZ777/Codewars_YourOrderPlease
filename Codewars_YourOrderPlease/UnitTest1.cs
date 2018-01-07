using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_YourOrderPlease
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Find_Input_1andEmpty_Should_Be_Empty()
        {
            Assert.AreEqual(string.Empty, Kata.Find(string.Empty, 1));
        }
    }

    public class Kata
    {
        public static string Find(string s, int n)
        {
            throw new NotImplementedException();
        }
    }
}
