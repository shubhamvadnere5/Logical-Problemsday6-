using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblemsDay6
{
    class Prime
    {
        static void Main(string[] args)
        {
            int n, num = 0;
            Console.WriteLine("ENTER A NUMBER");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Prime Number");
                    num = num + 1;
                    break;
                }
            }
            if (num == 0)
            {
                Console.WriteLine("Not a Prime Number");
            }
            Console.ReadLine();
        }
    }
}
