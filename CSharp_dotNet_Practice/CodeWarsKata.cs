using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_dotNet_Practice
{
    public class CodeWarsKata
    {
        // take in any non-negative integer as an argument and return it with its digits in descending order
        // in other words, rearrange the digits to create the highest possible number
        //public int DescendingOrder(int num)
        //{
        //    string mynum = num.ToString();
        //    var digits = mynum.Select(x => Convert.ToInt32(x.ToString())).ToList();
        //    digits.Sort();
        //    digits.Reverse();
        //    string stringResult = "";
        //    foreach (int digit in digits)
        //    {
        //        digit.ToString();
        //        stringResult += digit;
        //    }
        //    int result = Convert.ToInt32(stringResult);
        //    return result;
        //}

        //given the triangle of consecutive odd numbers
        //calculate the row sums of this triangle
        //              1
        //          3       5
        //      7       9       11
        //13        15      17      19


        //public long rowSumOddNumbers(long n)
        //{
        //    if (n == 1)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        long startingNum = (Convert.ToInt64(Math.Pow(n,2))) - (n - 1);
        //        long result = 0;
        //        long counter = 0;
        //        for (var i = startingNum; counter < n; i += 2)
        //        {
        //            result += i;
        //            counter++;
        //        }
        //        return result;
        //    }
        //}

        //find the next integral perfect square after n
        //if the parameter is not a perfect square return -1

        //public long FindNextSquare(long num)
        //{
        //    if (Math.Sqrt(num) % 1 != 0)
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        long i = num + 1;
        //        while (Math.Sqrt(i) % 1 != 0)
        //        {
        //            i++;
        //        }
        //        return i;
        //    }
        //}

        //public string SpinWords(string sentence)
        //{

        //    string[] words = sentence.Split(' ');
        //    List<string> resultList = new List<string>();

        //    foreach (string word in words)
        //    {
        //        if (word.Length >= 5)
        //        {
        //            string backwardsWord = "";
        //            for (var i = word.Length - 1; i >= 0; i--)
        //            {
        //                backwardsWord += word[i];
        //            }
        //            resultList.Add(backwardsWord);
        //        }
        //        else
        //        {
        //            resultList.Add(word);
        //        }
        //    }
        //    string result = string.Join(" ", resultList);
        //    return result;
        //}

        public string LikeSystem(string[] likers)
        {
            int likes = likers.Length;

            switch (likes)
            {
                case 0:
                    return "No one likes this";
                case 1:
                    return likers[0] + " likes this";
                case 2:
                    return likers[0] + " and " + likers[1] + " likes this";
                case 3:
                    return likers[0] + ", " + likers[1] +" and " + likers[2] + " likes this";
                default:
                    return likers[0] + ", " + likers[1] + " and " +  (likes - 2) + " others likes this";
            }
        }
    }
}
