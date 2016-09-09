using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {

            string answerdragonName = "";
            Console.WriteLine("Welcome! What is your name? (Enter your name)");
            string userName = Console.ReadLine();

            Console.WriteLine("Would you like to play a game? (yes or no)");
            string GAME = Console.ReadLine();

            if (GAME == "y" || GAME == "yes")
            {
                Console.WriteLine("Hey " + userName);
                Console.WriteLine("Welcome to the game" + "Would you like to do?" + " Face the Beast or Run away");

                string answerToFaceOrRun = Console.ReadLine();

                if (answerToFaceOrRun == "Face the Beast")
                {

                    Console.WriteLine("You approach the dragon. How many Heads does the dragon have?" + ("enter 1, 2, 3"));
                    string numberHeads = Console.ReadLine();

                    Console.WriteLine("No one has ever faced a " + numberHeads+ "-headed dragon before! Choose your weapon. enter Slingshot,Sword,Bow and arrow");
                    string whichWeapon = Console.ReadLine();
                    switch (whichWeapon.ToLower())
                    {
                        case "sword":
                        case "slingshot":
                        case "Bow and arrow":
                            Console.WriteLine("Armed with " + whichWeapon + ", you approach the dragon.  You can feel its fiery breath as you get closer.  It stares at you with its_eyes. (enter \"red\", \"blue\")");
                            string eyeColor = Console.ReadLine();



                            switch (eyeColor)
                            {
                                case "red":
                                case "blue":
                                    Console.WriteLine("Oh thank goodness!" + eyeColor + " -eyed dragons are friendly.  You pet it and become friends.");
                                    Console.WriteLine("You name the dragon" + answerdragonName);

                                    answerdragonName = Console.ReadLine();
                                    break;
                                default:
                                    break;
                            }

                            break;
                        default:
                            break;
                            {

                            }





                            //You approach the dragon.  You see that he has_heads.  (enter 1,2,3)
                            //No one has ever faced a three-headed dragon before! Choose your weapon (enter "Slingshot", "Sword", "Bow and aerro")
                            //Armed with your bow and arrow, you approach the dragon.  You can feel its fiery breath as you get closer.  It states at you with its_eyes.  (enter "red" or "blue")
                            //Oh thank goodness! Red-eyed dragons are friendly.  You pet it and become friends.



                    }
                }
                else {
                    Console.WriteLine("Bye Bye!");
                }
                Console.WriteLine("Aisha and " + answerdragonName + " live happily ever after.");
                Console.ReadLine();

            }
        }
    }
}



//You approach the dragon.  You see that he has_heads.  (enter 1,2,3)
//No one has ever faced a three-headed dragon before! Choose your weapon (enter "Slingshot", "Sword", "Bow and aerro")
//Armed with your bow and arrow, you approach the dragon.  You can feel its fiery breath as you get closer.  It states at you with its_eyes.  (enter "red" or "blue")
//Oh thank goodness! Red-eyed dragons are friendly.  You pet it and become friends.   You name the dragon_.  