using System;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var i in Enumerable.Range(1, 100)) Console.WriteLine("{0:#}{1:;;Fizz}{2:;;Buzz}", i % 3 == 0 || i % 5 == 0 ? 0 : i, i % 3, i % 5);
        }
    }
}
