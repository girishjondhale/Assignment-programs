using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public class Freqofcharstr
    {
        public void Getfreq(char[] ch)

        {


            for (int i = 0; i < ch.Length; i++)
            {
                bool isvisited = false;
                int count = 1;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (ch[k] == ch[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < ch.Length; j++)
                    {
                        if (ch[j] == ch[i])
                        {
                            count++;
                        }

                    }
                }
                if (ch[i] != ' ')
                {
                    Console.WriteLine(count + " " + ch[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any String");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();

            Freqofcharstr f = new Freqofcharstr();
            f.Getfreq(ch);

        }

    }
}
