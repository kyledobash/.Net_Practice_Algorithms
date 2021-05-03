using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CSharp_dotNet_Practice;

namespace CSharp_dotNet_Practice.UnitTests
{
    [TestClass]
    public class Algorithm_Tests
    {
        [TestMethod]
        public void ReverseString_InputEmptyString_ReturnEmptyString()
        {
            //arrange
            CodeWarsKata test = new CodeWarsKata();
            string emptyString = "";

            string expected = "";
            string actual;

            //act
            actual = test.reverseString("");

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
