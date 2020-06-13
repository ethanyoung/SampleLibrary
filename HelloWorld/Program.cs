using System;
using McMathLib;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var math = new MathClass();
            var number = math.Calculate(1, 2, "Mul");
            Console.WriteLine(number);
        }
    }
}
