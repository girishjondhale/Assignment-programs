using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    internal class Stringrev
    {
        public static string Strr(string s)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i] + " ");
            }
            return s;
        }
        static void Main(string[] args)
        {
            string str = "Girish hi";
           Stringrev.Strr(str);
        }
    }
}
