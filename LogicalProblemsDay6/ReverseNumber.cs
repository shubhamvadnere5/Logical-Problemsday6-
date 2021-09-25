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
            int n, Reverse = 0;
            Console.WriteLine("Enter a number"); // 56
            n = Convert.ToInt32(Console.ReadLine()); // 56
            while (n > 0) // (56>0)
            {
                int num = n % 10; // num = 56 % 10 = 6  // num = 6
                Reverse = Reverse * 10 + num; //  sum = 0*10+6 = 6 // sum = 6
                n = n / 10; // n = 56/10 
            }
            Console.WriteLine("THE Reverse Of number is :" + Reverse);
            Console.ReadLine();
        }

    }
}