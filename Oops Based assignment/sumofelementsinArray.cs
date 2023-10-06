using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Based_assignment
{
    internal class sumofelementsinArray
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] marks = { 1, 5, 3, 4, 5, 8, 2 };
            for (int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }
            Console.WriteLine($"sum of the elements of the array is : {sum}");
            Console.WriteLine("------------------------------------------------------");
     
            int x = marks.Sum();
            Console.WriteLine($"sum of the elements of the array is : {x}");
            Console.ReadLine();
        }
    }
}
