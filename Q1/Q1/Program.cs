using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product P1 = new Product();// Display default values
            Product P2 = new Product(1001,"PC",20000m,15);//id, name,price,quantity
            Product P3 = new Product(1002, "Keyboard", 500m);//id , name and price
            Product P4 = new Product(1003,"",0, 20);//id and quantity
            Product P5 = new Product(1004, "USB");//id and name
            

            //STORE
            Store mystore =new Store("Abid","FSD");
            mystore.Add_products_in_store(P1);
            mystore.Add_products_in_store(P2);
            mystore.Add_products_in_store(P3);
            mystore.Add_products_in_store(P4);
            mystore.Add_products_in_store(P5);
            mystore.Display_all_products();

            Console.WriteLine("Now we are killing objescts. ");
            //Destructor
            mystore = null;
            P5 = null;
            P4 = null;
            P3 = null;
            P2 = null;
            P1 = null;

            //RUN Garbage collector

            GC.Collect();
            GC.WaitForPendingFinalizers();
            

        }
    }
}
