using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5___Dice_roll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice to begine the game (hit \"y + enter\" to begin game \"n\" to END GAME)? \n");
            string diceGame = Console.ReadLine();

            if ("y" == diceGame)
            {
                Console.WriteLine("How many sides do you want your dice?");
                int numSides = int.Parse(Console.ReadLine());

                if (numSides > 1)
                {
                    // loop starts here.
                    string  numRoll;
                    do
                        {
                        Console.WriteLine("Roll the dice? (y/n)");
                        numRoll = Console.ReadLine();
                        Random diceThrow = new Random();

                        int roll1 = diceThrow.Next(numSides);
                        int roll2 = diceThrow.Next(numSides);
                        Console.WriteLine(roll1 +","+ roll2);
                    }
                    while ("y" == numRoll);


                    }
                else

                { Console.WriteLine("END GAME"); }

            }
            else { Console.WriteLine("END GAME"); }
            



















            Console.WriteLine("Roll Again (y/n)");
            //end of the loop here.  }



            // (Console.ReadLine("End Game") == "n");

            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
