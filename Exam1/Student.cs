//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Exam1
//{
//    internal class Student
//    {
//        public int id;
//        public string name;
//        public int m1;
//        public int m2;
//        public int m3;
//        int percentage;
//        public void Acceptdetails(int id, string name, int m1, int m2, int m3)
//        { 
//            this.id = id;
//            this.name = name;
//            this.m1 = m1;
//            this.m2 = m2;
//            this.m3 = m3;
//        }
//        public void Calculatepercentage()
//        {
//            percentage = (m1 + m2 + m3)/3;
//            CalGrade();
//            DisplayAll();


//        }
//        public void CalGrade()
//        { 
//            if (percentage  > 90) 
//            {
//                Console.WriteLine("grade A");
//            }
//            else if(percentage >80) 
//            {
//                Console.WriteLine("grade B");
//            }
//            else if (percentage > 60)
//            {
//                Console.WriteLine("grade B");
//            }
//            else if (percentage > 50)
//            {
//                Console.WriteLine("grade B");
//            }
//            else if (percentage <50)
//            {
//                Console.WriteLine("fail");
//            }
           
//        }
//        public void DisplayAll()
//        {
//            Console.WriteLine(id);
//            Console.WriteLine(name);
//            Console.WriteLine(m1);
//            Console.WriteLine(m2);
//            Console.WriteLine(m3);
//            Console.WriteLine(percentage);
//            Console.WriteLine();

//        }

//        static void Main(string[] args)
//        {
//            Student student = new Student();
//            student.Acceptdetails(1, "girish", 87, 90, 75);
//            student.Calculatepercentage();
//            Console.ReadLine();
//        }
//    }
//}
