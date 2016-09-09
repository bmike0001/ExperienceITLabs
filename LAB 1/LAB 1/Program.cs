using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome \n");
            string cont = "y";
            do
            {
                Console.WriteLine("Enter Length?");

                double a = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Width?");
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine($"Area is: {a*b}");
                Console.WriteLine($"perimeter is {2*a + 2*b}");

                Console.WriteLine("Do you want to continue y/n");
                cont = Console.ReadLine();
            }
            while (cont == "y");
                Console.WriteLine("Goodbye");
            
                Console.ReadLine();
        }
            }
    }



