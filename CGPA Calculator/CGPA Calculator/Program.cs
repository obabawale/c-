using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGPA_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName;
            Console.WriteLine("Hello World");
           

            Console.WriteLine("Enter Student Name");
            studentName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Welcome {0} ", studentName);
            Console.ReadKey();
        }
    }
}
