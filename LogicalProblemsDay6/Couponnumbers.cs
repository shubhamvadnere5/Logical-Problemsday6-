using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblemsDay6
{
    class CouponNumbers
    {
        
        public static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 100);
            int n = 0;
            
            while (n <= 10)
            {
                int num = random.Next(1, 100);
                Console.WriteLine("The coupon number is :" + num);
                n++;
            }
            Console.ReadLine();
        }
    }
}
