using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblemsDay6
{
    class PerfectNumber
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            Console.WriteLine("Enter a number : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
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