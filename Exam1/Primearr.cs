//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Exam1
//{
//    public class Primearr
//    {
//        public static bool IsPrimeNumber(int a)
//        {
//            for (int i = 2; i < a; i++)
//            {
//                if (a % i == 0)
//                {

//                    return false;
//                    //break;
//                }
//            }
//            return true;

//        }
//        static void Main(string[] args)
//        {
//            int[] a = { 2, 6, 4, 5,11 };
//            int sum = 0;
//            int count = 0;
//            for (int i = 0; i < a.Length; i++)
//            {
//                if (Primearr.IsPrimeNumber(a[i]))
//                {
//                    Console.WriteLine(a[i]);
//                    sum = sum + a[i];
//                    count++;


//                }
//            }
//            Console.WriteLine("avg= " + sum / count);
//        }
//    }
//}

