// Fig. 8.19: AssemblyTest.cs
// Using class Time3 from assembly TimeLibrary.

using System;
using TimeLibrary;

// AssemblyTest class definition
class AssemblyTest
{
    // main entry point for application
    static void Main(string[] args)
    {
        Time3 time = new Time3(13, 27, 6);

        Console.WriteLine(
        "Standard time: {0}\nUniversal time: {1}\n",
        time.ToStandardString(), time.ToUniversalString());
        Console.ReadKey();
    }
}