using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSharp_dotNet_Practice.UnitTests
{
    [TestClass]
    public class isPalinDromeTests
    {
        [TestMethod]
        public void isPalindrome_InputEmptyString_ReturnsTrue()
        {
            //arange
            CodeWarsKata test = new CodeWarsKata();
            string emptyString = "";

            bool expected = true;
            bool actual;

            //act
            actual = test.isPalindrome(emptyString);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
