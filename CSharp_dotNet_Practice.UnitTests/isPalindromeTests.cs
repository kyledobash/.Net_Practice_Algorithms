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

        [TestMethod]
        public void isPalindrome_InputSingleChar_ReturnsTrue()
        {
            //arange
            CodeWarsKata test = new CodeWarsKata();
            string singleChar = "k";

            bool expected = true;
            bool actual;

            //act
            actual = test.isPalindrome(singleChar);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isPalindrome_InputPalindromeWithSpaces_ReturnsTrue()
        {
            //arange
            CodeWarsKata test = new CodeWarsKata();
            string palindrome = " oo ";

            bool expected = true;
            bool actual;

            //act
            actual = test.isPalindrome(palindrome);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isPalindrome_InputNotPalindromeWithSpaces_ReturnsFalse()
        {
            //arange
            CodeWarsKata test = new CodeWarsKata();
            string notPalindrome = " kyle ";

            bool expected = false;
            bool actual;

            //act
            actual = test.isPalindrome(notPalindrome);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isPalindrome_InputPalindromeWithoutSpaces_ReturnsTrue()
        {
            //arange
            CodeWarsKata test = new CodeWarsKata();
            string palindromeNoSpaces = "racecar";

            bool expected = true;
            bool actual;

            //act
            actual = test.isPalindrome(palindromeNoSpaces);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isPalindrome_InputNotPalindromeWithoutSpaces_ReturnsFalse()
        {
            //arange
            CodeWarsKata test = new CodeWarsKata();
            string notPalindromeNoSpaces = "kyle";

            bool expected = false;
            bool actual;

            //act
            actual = test.isPalindrome(notPalindromeNoSpaces);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
