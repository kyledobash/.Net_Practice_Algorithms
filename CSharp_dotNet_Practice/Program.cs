using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_dotNet_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeWarsKata test = new CodeWarsKata();


            //Console.WriteLine(test.DescendingOrder(16544));
            //Console.WriteLine(test.DescendingOrder(98547));
            //Console.WriteLine(test.DescendingOrder(1100000));
            //Console.WriteLine(test.DescendingOrder(0000011));

            //Console.WriteLine(test.rowSumOddNumbers(1));
            //Console.WriteLine(test.rowSumOddNumbers(2));
            //Console.WriteLine(test.rowSumOddNumbers(3));
            //Console.WriteLine(test.rowSumOddNumbers(4));

            //Console.WriteLine(test.FindNextSquare(155));
            //Console.WriteLine(test.FindNextSquare(625));
            //Console.WriteLine(test.FindNextSquare(114));

            //Console.WriteLine(test.SpinWords("Kyle Dobash"));
            //Console.WriteLine(test.SpinWords("Slater Higgins"));
            //Console.WriteLine(test.SpinWords("Nick Couch"));
            //Console.WriteLine(test.SpinWords("Logan Lauck"));
            //Console.ReadLine();

            Console.WriteLine(test.LikeSystem(new string[0]));
            Console.WriteLine(test.LikeSystem(new string[] {"Kyle"}));
            Console.WriteLine(test.LikeSystem(new string[] {"Kyle", "Slater"}));
            Console.WriteLine(test.LikeSystem(new string[] {"Kyle", "Slater", "Logan"}));
            Console.WriteLine(test.LikeSystem(new string[] {"Kyle", "Slater", "Logan", "Nick"}));
            Console.ReadLine();
            
            
        }
    }
}
