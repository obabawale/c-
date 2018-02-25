using System;
using System.Windows.Forms;

class sum
{
    static void Main(string[] args)
    {
        double r = .05,
            p=1000,
            a;
        Console.WriteLine("Year" + "Amount");
        for (int n = 1; n <= 10; n += 1)
        {
            a = p * Math.Pow((1 + r), n);
            Console.WriteLine("{0},{1}", n,a);
            p = a;
        }
        Console.ReadKey();

    } // end method Main

} // end class Sum




