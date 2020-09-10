using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter 2 numbers");
                int a = Convert.ToInt32(Console.ReadLine());
                while (a == 0)
                {
                    Console.WriteLine("Number cant be 0.Enter again");
                    a = Convert.ToInt32(Console.ReadLine());

                }

                int b = Convert.ToInt32(Console.ReadLine());
                while (b == 0)
                {
                    Console.WriteLine("Number cant be 0.Enter again");
                    b = Convert.ToInt32(Console.ReadLine());

                }
                int sum = a + b;
                int product = a * b;
                Console.WriteLine("Sum :" + sum);
                Console.WriteLine("Product: " + product);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
