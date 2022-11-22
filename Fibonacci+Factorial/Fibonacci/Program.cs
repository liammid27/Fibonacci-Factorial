using System;

namespace Fibonacci
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //Prints the fibonacci sequence up to the tenth number
            int first = 0;
            int second = 1; 
            int third = 0;
            Console.Write("{0} {1}", first, second);
            for (int i = 2; i < 10; i++)
            {
                third = first + second;
                Console.Write(" {0}", third);
                first = second;
                second = third;
            }

            Console.WriteLine("\n " + Factorial(6)); 
        }

        static int Factorial(int n)
        {
            //Gets the factorial of a given number
            int current = 1, i;

            for (i = 2; i < n; i++)
            {
                current *= i;
            }

            return current;
        }
        
    }
}
