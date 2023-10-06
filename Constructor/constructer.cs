using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class constructer
    {
        static void Main(string[] args)
        {
            constructorgetset p1 = new constructorgetset("Tesla",500.2,2);
            constructorgetset p2 = new constructorgetset("TATA", 200.2, 5);
            constructorgetset p3 = new constructorgetset("Rolex", 1500.2, 1);
            constructorgetset p4 = new constructorgetset("BlueOrange", 78.2, 3);
            constructorgetset p5 = new constructorgetset("Nike", 125.2, 1);

            Console.WriteLine("products :");
            Console.WriteLine($"product 1 is : {p1.name},{p1.price},{p1.quantity}");
            Console.WriteLine($"product 2 is : {p2.name},{p2.price},{p2.quantity}"); 
            Console.WriteLine($"product 3 is : {p3.name},{p3.price},{p3.quantity}");
            Console.WriteLine($"product 4 is : {p4.name},{p4.price},{p4.quantity}");
            Console.WriteLine($"product 5 is : {p5.name},{p5.price},{p5.quantity}");
            Console.ReadLine();

        }
    }
}
