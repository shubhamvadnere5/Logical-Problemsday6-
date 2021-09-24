//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LogicalProblemsDay6
//{
//    // if the sum of its positive divisors excluding the number itself is equal to that number.
//    class PerfectNumber
//    {
//        static void Main(string[] args)
//        {
//            int n, sum = 0;   //1+ 2 + 3 = 6(sum)
//            Console.WriteLine("Enter a number : ");  // user input
//            n = Convert.ToInt32(Console.ReadLine()); // type cast n =  6

//            for (int i = 1; i <= n / 2; i++) // (i = 1, 3 <= 3, 3++)
//            {
//                if (n % 2 == 0) //(6%2==0)
//                {
//                    sum = sum + i; // sum = 3+3 = sum = 6
//                }
//            }


//            if (n % sum == 0) // (6 % 6 == 0) 
//            {
//                Console.WriteLine(" Is Perfect number");
//            }
//            else
//            {
//                Console.WriteLine("Not a perfect number");
//            }
//            Console.ReadLine();
//        }
//    }
//}