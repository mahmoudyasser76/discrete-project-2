using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number range to get the perfect numbers between them:");
            int num1 = int.Parse(Console.ReadLine());
            int num2= int.Parse(Console.ReadLine());
            int i, j;
            Console.WriteLine("perfect numbers between "+ num1 +" and "+ num2 +":");
            for (i = num1; i <= num2; i++)
            {
                int sum= 0;
                for (j = 1; j < i; j++)
                {
                    if ( i % j == 0)
                    {
                        sum+= j;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}