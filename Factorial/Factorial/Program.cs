using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number=1;
            int factorial=1;
            int key;
            Console.WriteLine("Please enter the number for which factorial should be calculated");
            key = Int32.Parse(Console.ReadLine());
            while (number <= key)
            {
                factorial *= number;
                number++;   
            }
            Console.WriteLine("{0}! = {1}",key,factorial);
            Console.ReadKey();
        }
    }
}
