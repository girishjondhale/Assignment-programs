using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    internal class Chararrtoggle
    {
        //public static string A1(string c)
        //{
            
        //    for (int i = 0; i < c.Length-1; i++)
        //    {
        //        ch = c[i];
        //    }
        //    return c;
        //}
        static void Main(string[] args)
        {

            char[] ch = { 'A','b','C','d' };
            char c;
            for (int i = 0; i <ch.Length; i++)
            {
                c = ch[i];
                if (Char.IsLower(c))
                {
                    Console.WriteLine(Char.ToUpper(c));
                }
                else 
                {
                    Console.WriteLine(Char.ToLower(c));
                }
            }
        }
    }
}
