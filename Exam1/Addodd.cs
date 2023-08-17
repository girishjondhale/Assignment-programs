using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    internal class Addodd
    {
        static void Main(string[] args)
        {
            int n = 23574;
            int sum= 0;
            while(n > 0) 
            {
                int digit= n % 10;
                if (digit % 2 == 1)
                {
       
                    sum =sum + digit;
                    
                }
                n=n/10;
            }
            Console.WriteLine(sum);
        }
    }
}
