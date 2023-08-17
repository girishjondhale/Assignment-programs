//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Exam1
//{
//    internal class Program
//    {
//        int product_id;
//        string product_name;
//        int price;
//        int qty;
//        int bill;
//        public void AcceptDetails(int product_id, string pname, int price, int qty)
//        { 
//            this.product_id = product_id;
//            this.product_name = pname;
//            this.price = price;
//            this.qty = qty;

//        }
//        public void Calculatebill()
//        {
//            if (qty > 0)
//            {
//                bill = qty * price;
//                ShowDetails();
//            }
//            else 
//            {
//                throw new Exception("please provid qty");
//            }
//        }
//        public void ShowDetails()
//        {
//            Console.WriteLine(product_id);
//            Console.WriteLine(product_name  );
//            Console.WriteLine(qty);
//            Console.WriteLine(price);
//            Console.WriteLine(bill);
//        }
//    }
//}

