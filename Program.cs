using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMultiply
{
    class Program
    {
        static int add(int a, int b)
        {
            int carry;
            while (b != 0)
            {
                carry = (a & b) << 1;
                a = a ^ b;
                b = carry;
            }
            return a;
        }

        static void Main(string[] args)
        {
            int n1, n2, mul = 0, i;
            Console.Write("Enter First Number : ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Number : ");
            n2 = int.Parse(Console.ReadLine());

            for (i = 0; i < n2; i++)
            {
                mul = add(mul, n1);
            }
            Console.WriteLine("The multiplication of " + n1 + " and " + n2 + " is " + mul+".");
            Console.ReadKey();
        }
    }
}