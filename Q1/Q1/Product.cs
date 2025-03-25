using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Product
    {
        private int Product_Id;
        private string Name;
        private decimal Price;
        private int Quantity_in_Stock;



            public void Check_Quantity(int Q_in_Stock)
          {
              if (Q_in_Stock > 0 && Q_in_Stock < 101)
              {
                  Quantity_in_Stock = Q_in_Stock;
              }
              else
              {
                  Console.WriteLine("Please enter range of stock b/w 1-100");
                  Quantity_in_Stock = 0;
              }
          }
       /* public Product(int product_Id, string name, decimal price, int Q_in_Stock)
          {
              Product_Id = product_Id;
              Name = name;
              Price = price;
              Check_Quantity(Q_in_Stock);
          }
          public Product(int product_Id, string name, decimal price) : this(product_Id, name, price, 0)
          {
          }
          public Product(int product_Id,  decimal price) : this(product_Id, "", price, 0)
          {
          }
          public Product(int product_Id, string name) : this(product_Id, name, 0, 0)
          { 
          }
          public Product(int product_Id, int Q_in_Stock) : this(product_Id, "", 0, Q_in_Stock)
          { }*/

        //other Overloading Approach
        public Product(int product_Id = 1, string name = "", decimal price = 0, int Q_in_Stock = 1)
        {
            Product_Id = product_Id;
            Name = name;
            Price = price;
            Check_Quantity(Q_in_Stock);
        }
        public void Display()
        {
            
            Console.WriteLine($"Product ID       = {Product_Id}");
            Console.WriteLine($"Product Name     = {Name}");
            Console.WriteLine($"Price            = {Price}");
            Console.WriteLine($"Product Quantity = {Quantity_in_Stock}\n");
           
        }
       ~ Product()
        {
            Console.WriteLine($"Product have ID {Product_Id} is killed.");
        }

    }
}
