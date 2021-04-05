﻿using System;
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

        public long FindNextSquare(long num)
        {
            if (Math.Sqrt(num) % 1 != 0)
            {
                return -1;
            }
            else
            {
                long i = num + 1;
                while (Math.Sqrt(i) % 1 != 0)
                {
                    i++;
                }
                return i;
            }
        }
    }
}
