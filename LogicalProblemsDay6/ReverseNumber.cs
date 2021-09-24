using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblemsDay6
{
    class ReverseNumber
    {

        static void Main(string[] args)
        {
            int n, sum = 0;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                int num = n % 10;
                sum = sum * 10 + num;
                n = n / 10;
            }
            Console.WriteLine("THE Reverse Of number is :" + sum);
            Console.ReadLine();
        }

    }
}
