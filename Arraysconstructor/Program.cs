using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraysconstructor
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // Creating an array of Product class to store 5 products
            Product[] products = new Product[5];

            // Accepting input for 5 products
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter name for product {i + 1}: ");
                string name = Console.ReadLine();

                Console.WriteLine($"Enter price for product {i + 1}: ");
                double price = Convert.ToDouble(Console.ReadLine());

                // Creating a new Product object and storing it in the array
                products[i] = new Product { Name = name, Price = price };
            }

            // Displaying product information
            Console.WriteLine("Products:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i].Name} - ${products[i].Price}");
            }
            Console.ReadLine();

            Console.WriteLine("--------------------------------------------------------------------");


        }

    }
}
