using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    internal class Maxofarr
    {
        static void Main(string[] args)
        {
            // max num in array
            //            int[] arr = new int[5] { 10, 4, 2, 6, 3 };
            //             int max = 0;
            //            for (int i = 0; i < arr.Length; i++)
            //            {
            //                if (arr[i]> max)
            //                {
            //                    max = arr[i];
            //                }
            //            }
            //            Console.WriteLine(max);


            //  prime number

            //int[] a = { 1, 2, 3, 4, 5, };
            int a = 10;
            int count = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a%i == 0)
                {
                    count++;
                }

            }
            if (count == 2)
            {
                Console.WriteLine( " prime" );
            }
            else 
            { Console.WriteLine("not prime"); }
        
        }

    }
}
