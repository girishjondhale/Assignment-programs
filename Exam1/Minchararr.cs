using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public class Minchararr
    {
        public static char Checkchar(char[] arr)
        {
            char min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            char[] arr = { 'a', 'b', 'C', 'd' };
            char a=Minchararr.Checkchar(arr);
            Console.WriteLine(a);
        }
    }
}
