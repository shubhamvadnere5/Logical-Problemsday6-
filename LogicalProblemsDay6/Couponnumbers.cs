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
            Random random = new Random(); // random object created
            int n = 0; // for iteration took n = 0 i.e while loop will star from zero

            while (n < 10)
            {
                int num = random.Next(1, 100); // from object number Next method called Nest(start,end)
                Console.WriteLine("The coupon number is :" + num); // random number will print
                n++; // n's value will be incresed i.e 0++
            }
            Console.ReadLine();
        }
    }
}