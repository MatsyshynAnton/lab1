using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Value of third Fibonacci number: {GetFibonacciWrapper(3)}");
            Console.WriteLine($"Value of fifth Fibonacci number: {GetFibonacciWrapper(5)}");
            Console.WriteLine($"Value of ninth Fibonacci number: {GetFibonacciWrapper(9)}");
        }

        static int GetFibonacciWrapper(int seqNumber)
        {
            seqNumber -= 2;
            return GetFibonacci(seqNumber);
        }
        static int GetFibonacci(int seqNumber, int first = 0, int second = 1)
        {
            if (seqNumber <= 0)
                return first + second;

            return GetFibonacci(--seqNumber, second, first + second);
        }
    }
}
