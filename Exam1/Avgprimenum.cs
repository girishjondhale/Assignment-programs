using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam1
{
    //average of prime digits in number
    internal class Avgprimenum
    {
    
        static void Main(string[] args)
        {
            int num = 234567;
            int sum = 0;
            int count = 0;
            while (num > 0) 
            {
                int digit =num % 10;
                if (digit%2 == 0) 
                {
                    
                }
                sum += digit;
                count++;
            }
            num=num/10;
            Console.WriteLine(sum/count);
        }
    }
}
