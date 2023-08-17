using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public class Class2
    {
        static int index;
        //num present in array
        public static bool Searchnum(int [] a,int num)
        {
            for (int i = 0; i <a.Length; i++)
            {
                if (a[i] == num)
                {
                    index = i;
                  return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {   
            
            int[] a = { 1, 2, 3, 4, 5, };
            int num = 4;
           bool result=Class2.Searchnum(a, num);
            if (result==true) 
            {
                Console.WriteLine("present"+index);
            }
            else { Console.WriteLine("not present"); }
        }
    }
}
