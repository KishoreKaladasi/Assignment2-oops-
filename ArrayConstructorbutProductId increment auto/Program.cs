using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConstructorbutProductId_increment_auto
{
     
            

class Product
        {
            private static int nextProductId = 1;

            public int ProductId { get; private set; }
            public string Name { get; set; }
            public double Price { get; set; }

            public Product(string name, double price)
            {
                ProductId = nextProductId++;
                Name = name;
                Price = price;
            }
        }

        class Program
        {
            static void Main()
            {
                // Creating an array of Product class to store 5 products
                Product[] products = new Product[5];

                // Accepting data for 5 products
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"Enter name for product {i + 1}: ");
                    string name = Console.ReadLine();

                    Console.Write($"Enter price for product {i + 1}: $");
                    double price = Convert.ToDouble(Console.ReadLine());

                    // Creating Product object and storing it in the array
                    products[i] = new Product(name, price);
                }

                // Displaying product information with ProductId
                Console.WriteLine("\nProducts:");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{i + 1}. ProductId: {products[i].ProductId}, Name: {products[i].Name}, Price: ${products[i].Price}");
                }
            Console.ReadLine();
            }
         
        }
    
    }
    