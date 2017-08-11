using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolE
{
    class E1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            //decrement version:
            //for (int i = n; i >= 1; i--)
            //{
            //    fact *= i;
            //}

            Console.WriteLine(fact);

            //some potential problem: it will overflow and exceed the upper limit of integer.
            //in production code, need to add some validation to ensure that that doesn't happen
            //some validation can be done for example: to check if (n! / n) is equal to (n-1)!
            //when overflow happens, the two may not be equal.
        }
    }
}
