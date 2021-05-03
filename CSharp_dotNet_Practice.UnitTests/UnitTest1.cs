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
            actual = test.reverseString(emptyString);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReverseString_InputSingleChar_ReturnSingleChar()
        {
            //arrange
            CodeWarsKata test = new CodeWarsKata();
            string singleChar = "k";

            string expected = "k";
            string actual;

            //act
            actual = test.reverseString(singleChar);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReverseString_InputRepeatChars_ReturnRepeatChars()
        {
            //arrange
            CodeWarsKata test = new CodeWarsKata();
            string repeatChars = "kk";

            string expected = "kk";
            string actual;

            //act
            actual = test.reverseString(repeatChars);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
