using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4___Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Calculator \n");
            do
            {

                //loop starts here
                Console.WriteLine("Enter an integer that's greater than 0 but less than 10: (user input here.)");
                //reads information form the consoles and convert to a 
                //number to be use by the program




                string inputFactorial = Console.ReadLine();
                int factorialNumber = int.Parse(inputFactorial);

                //calculate a factorial

                int number = factorialNumber;
                for (int i = factorialNumber - 1; i > 0; i--)
                {
                    number = number * i;

                }



                Console.WriteLine(number);



                Console.WriteLine("Continue (y/n)");
                //end of the loop here.  

            } while (Console.ReadLine()=="y"    );

            Console.WriteLine("GAME OVER");
            
        }
    }


}