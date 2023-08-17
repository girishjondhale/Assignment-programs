using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    internal class Revarr
    {
        public static void Rev(int[] a)
        {
            for (int i = a.Length-1; i >=0; i--)
            {
                Console.WriteLine(a[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5,6,7,8,1,14,20,11};
            Revarr.Rev(arr);
        }
    }
}

