//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Exam1
//{
//    internal class Mergarray
//    {
//        static void Main(string[] args)
//        {
//            int[] arr1 = { 1, 2, 3, 4, 5, 6 };
//            int[] arr2 = { 7, 8, 9, 10, 11, 12 };

//            int[] arr3 = new int[arr1.Length + arr2.Length];
//            int count = 0;
//            for (int i = 0; i < arr1.Length; i++)
//            {
//                arr3[count] = arr1[i];
//                count++;
//            }
//            for (int i = 0; i < arr2.Length; i++)
//            {
//                arr3[count] = arr2[i];
//                count++;
//            }
//            foreach (int item in arr3)
//            {
//                Console.WriteLine(arr3[item]);
//            }
//        }
//    }
//}
