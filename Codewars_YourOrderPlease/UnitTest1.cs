using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_YourOrderPlease
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Find_Input_1andEmpty_Should_Be_Empty()
        {
            Assert.AreEqual(string.Empty, Kata.Find(new string[] { string.Empty }, 1));
        }

        [TestMethod]
        public void Find_Input_1and1_Should_Be_Empty()
        {
            Assert.AreEqual("1", Kata.Find(new string[] { "1" }, 1));
        }

        [TestMethod]
        public void Find_Input_2andIm2Hi1DZ3()
        {
            Assert.AreEqual("Im2", Kata.Find(new string[] { "Im2", "Hi1", "DZ3" }, 2));
        }

        [TestMethod]
        public void Find_Input_1andIm2Hi1DZ3()
        {
            Assert.AreEqual("Hi1", Kata.Find(new string[] { "Im2", "Hi1", "DZ3" }, 1));
        }

        [TestMethod]
        public void Find_Input_3andIm2Hi1DZ3()
        {
            Assert.AreEqual("DZ3", Kata.Find(new string[] { "Im2", "Hi1", "DZ3" }, 3));
        }

        [TestMethod]
        public void Input_Im2Hi1DZ3_Should_Be_Hi1Im2DZ3()
        {
            Assert.AreEqual("Hi1 Im2 DZ3", Kata.Order("Im2 Hi1 DZ3"));
        }

    }

    public class Kata
    {
        public static string Find(string[] strs, int n)
        {
            return strs.FirstOrDefault(x => x.Contains(n.ToString())) ?? string.Empty;
        }

        public static string Order(string str)
        {
            var splitted = str.Split();
            var result = new List<string>();
            for (int i = 1; i <= splitted.Length; i++)
            {
                result.Add(Find(splitted, i) ?? string.Empty);
            }
            return string.Join(" ", result);
        }
    }
}
