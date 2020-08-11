using System;

namespace UnitTestExample001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new FancyProcessor().AddIntegers(1, 1));
            Console.WriteLine(new FancyProcessor().AlwaysReturnsTrue());
        }
    }
}
