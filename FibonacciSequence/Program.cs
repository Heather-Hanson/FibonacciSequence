using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace FibonacciSequence
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter the length of the Fibonacci Series: ");
            int length = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", Fibonacci(i));
            }
            Console.ReadLine();
        }
        public static int Fibonacci(int n)
        {
            int firstnumber = 0, secondnumber = 1, result = 0;
            if (n == 0) return 0;
            if (n == 1) return 1;

            for (int i = 2; i <= n; i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }
            return result;
        }
    }

}
