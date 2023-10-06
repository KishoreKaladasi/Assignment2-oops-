using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product
{
    internal class products
    {
        static void Main(string[] args)
        {
            propertiesOfproducts x = new propertiesOfproducts();
            x.ProductId = 101;
            x.Name = "Tesla";
            x.Price = 500.85f;
            x.UoM = "parts";
            x.Quantity = 12;

            Console.WriteLine($"Product Id is : {x.ProductId}");
            Console.WriteLine($"Product name is : {x.Name}");
            Console.WriteLine($"Product price is : {x.Price}");
            Console.WriteLine($"Product UnitOfMeasurment is : {x.UoM}");
            Console.WriteLine($"Product Quantity is : {x.Quantity}");
            Console.ReadLine();


        }
    }
}
