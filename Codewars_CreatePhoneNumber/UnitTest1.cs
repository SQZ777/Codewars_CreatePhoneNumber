using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_CreatePhoneNumber
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input1234567890_Should_Be_Formatted()
        {
            Assert.AreEqual("(123) 456-7890", Kata.CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
        }

        [TestMethod]
        public void Input_1111111111_Should_Be_Formatted()
        {
            Assert.AreEqual("(111) 111-1111", Kata.CreatePhoneNumber(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        }
    }

    public class Kata
    {
        public static string CreatePhoneNumber(int[] nums)
        {
            var numString = string.Join("", nums);
            return AddParent(numString) + AddDash(numString);
        }

        private static string AddDash(string s)
        {
            return s.Substring(3, 3) + "-" + s.Substring(6, 4);
        }

        private static string AddParent(string s)
        {
            return "(" + s.Substring(0, 3) + ") ";
        }
    }
}
