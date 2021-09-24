//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//// a prime number is nothing but a number which is devided by itself only

//namespace LogicalProblemsDay6
//{
//    class Prime
//    {
//        static void Main(string[] args)
//        {

//            int n, num = 0;
//            //taking value from User
//            Console.WriteLine("ENTER A NUMBER"); //4
//            n = Convert.ToInt32(Console.ReadLine()); // type cast
//            for (int i = 2; i <= n / 2; i++) // (i=2,2<=2,2++)
//            {
//                if (n % i == 0) //(4 % 2 ==) 0
//                {
//                    Console.WriteLine("Not a Prime Number");
//                    num = num + 1; //value of num will be 1
//                    break;
//                }
//            }
//            if (num == 0)
//            {
//                Console.WriteLine("Prime Number");
//            }
//            Console.ReadLine();
//        }
//    }
//}
