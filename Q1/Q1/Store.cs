using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Store
    {
        public string Store_Name;
        public string Store_Location;
        private Product[] products;
        private int product_count;

        public Store(string store_Name, string store_Location)
        {
            Store_Name = store_Name;
            Store_Location = store_Location;
            products = new Product[100];
            product_count = 0;
        }
        public void Add_products_in_store(Product product)
        {
            if (product_count < products.Length)
            {
                products[product_count] = product;
                product_count++;
            }
            else
            {
                Console.WriteLine("Can not add more products as limit reached.");
            }
        }
        public void Display_all_products()
        {
            Console.WriteLine("\t\t\t\t\t-----PRODUCT INVENTORY-----\n");
            Console.WriteLine($"All inventory of the store  {Store_Name} at location {Store_Location} are display below:");
            foreach (var item in products)
            {
                if (item != null)
                {
              
                    item.Display();
                }
            }
        }
        //Destructor
        ~Store()
        {
            Console.WriteLine("Store Application is close now.");
        }


    }
}
