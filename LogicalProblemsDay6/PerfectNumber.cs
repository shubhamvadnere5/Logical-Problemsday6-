using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblemsDay6
{
    // if the sum of its positive divisors excluding the number itself is equal to that number.
    class PerfectNumber
    {
        static void Main(string[] args)
        {
            int n, sum = 0;  //
            Console.WriteLine("Enter a number : ");  // user input
            n = Convert.ToInt32(Console.ReadLine()); // type cast
            for (int i = 1; i <= 3 ; i++) // (i=1,i<=6/2,i++)  loop will be iterate 3 times (6/2 = 3)
            {
                if (n % 2 == 0) //(6%2==0)
                {
                    sum = sum + i; 
                }
            }
            if (n % sum == 0)  
            {
                Console.WriteLine(" Is Perfect number");
            }
            else
            {
                Console.WriteLine("Not a perfect number");
            }
            Console.ReadLine();
        }
    }
}