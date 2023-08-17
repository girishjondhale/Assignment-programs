using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public class Shiftting_zero
    {
        public static int[] Toshift(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    int c = 0;
                    if (array[j] == 0)
                    {
                        c = array[i];
                        array[i] = array[j];
                        array[j] = c;
                    }


                }


            }
            return array;

        }
        public static void Main(string[] args)
        {
            int[] array = { 8, 0, 1, 0, 3, 4, 0 };
            int[] res = Shiftting_zero.Toshift(array);
            foreach (var num in array)
            {
                Console.WriteLine(num);
            }

        }
    }
}

