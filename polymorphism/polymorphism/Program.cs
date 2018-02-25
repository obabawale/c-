using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars[] c = new Cars[2];

            c[0] = new newCars();
            c[1] = new oldCars();

            foreach(Cars key in c) 
            {
                key.printInfo();
            }
            Console.ReadKey();
        }
    }

    class Cars 
    {
        public  virtual void printInfo()
        {
            Console.WriteLine("This is the Cars class");
        }
    }

    class oldCars : Cars
    {
        public override void printInfo()
        {
            Console.WriteLine("This is the Old Cars class");
        }
    }

    class newCars : Cars
    {
        public override void printInfo()
        {
            Console.WriteLine("This is the New Cars class");
        }
    }
}
