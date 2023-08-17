using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    internal class Fascinatingnum
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            string result = "";

            for (int i = 1; i <= 3; i++)
            {
                result += (number * i);
            }

            Console.WriteLine(result);
            bool fascinating = true;
            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] == result[j])
                    {
                        fascinating = false;
                        break;
                    }
                }
            }

            if (fascinating == true)
                Console.WriteLine("Number is fascinating");
            else
                Console.WriteLine("Number is Not fascinating");
        }
    }

}

  

