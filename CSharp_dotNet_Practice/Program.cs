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
            Console.WriteLine(test.DescendingOrder(16544));
            Console.WriteLine(test.DescendingOrder(98547));
            Console.WriteLine(test.DescendingOrder(1100000));
            Console.WriteLine(test.DescendingOrder(0000011));
        }
    }
}
