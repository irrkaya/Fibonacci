using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fibonacciNumbers = new List<int> { 1, 1 };
            
            while (fibonacciNumbers.Count < 20)
            {
                var firstFibonacci = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var secondFibonacci = fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(firstFibonacci + secondFibonacci);
               
            }
            foreach (var fibonacci in fibonacciNumbers)
            {
                Console.WriteLine(fibonacci);
        
            }
        }
    }
}
