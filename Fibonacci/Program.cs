using System;

namespace Fibonacci
{
    public class Program
    {
        static void Main(string[] args)
        {
            FibonacciService.GenerateNumbers();
            Fibonacci fibonacci = new Fibonacci();

            Console.ReadKey();
        }

    }
}
