using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            //string str = "abcde fg";
            //char[] arr = str.ToCharArray();
            //foreach (char c in arr) 
            //{
            //    Console.WriteLine(c);
            //}
            //primenum
            //
            //int a = 2;
            //int count = 0;
            //for (int i = 2; i <a; i++)
            //{
            //    if (a % i == 0)
            //    { 
            //        count++;
            //    }
            //}
            //if(count==0)
            //{
            //    Console.WriteLine("prime"); 
            //}
            //else { Console.WriteLine("not prime"); }

            //    int n = 2;
            //    prime(n);


            //}
            //public static int prime(int a) 
            //{
            //    int count = 0;
            //    for (int i = 2; i < a; i++) 
            //    {
            //        if (a % i == 0)
            //        { 
            //            count++;
            //        }
            //    }
            //    if (count == 0) 
            //    {
            //        Console.WriteLine("prime");
            //    }
            //    else { Console.WriteLine("not prime"); }
            //    return a;

            //    int n = 123;
            //    int sum = 0;
            //    while (n>0) 
            //    {
            //        int digit =n% 10;
            //        sum += digit;
            //        n = n / 10;
            //    }

            //    Console.WriteLine(sum);

            //int n = 368;
            //int mul = 1;
            //while (n > 0) 
            //{
            //    int digit = n % 10;
            //    mul = mul*digit;
            //    n = n/10;
            //}
            //Console.WriteLine(mul);
            //string s = "acd fg";
            //char[] chars = s.ToCharArray();
            //for (int i = 0; i < chars.Length-1; i++)
            //{
            //    if (chars[i]<3)
            //    {

            //    }
            //}

            string s1 = "nayan";
            string rev = "";
            for (int i = s1.Length-1; i >=0; i--)
            {
                rev =rev+ s1[i];
            }
            if (rev == s1)
            {
                Console.WriteLine("string is palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
        }
    }    
}
    
