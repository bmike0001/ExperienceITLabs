using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3__Squares.Cubes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!");
            Console.WriteLine("Enter an integer:");
            string squareNum = Console.ReadLine();

            int number = int.Parse(squareNum);

            for(int i=1; i<=number;i++)
            { 
                int square = i * i;
                int cube = square * i;

                Console.WriteLine(i + " " + square + " " + cube);
            }


            Console.ReadLine();
        }
}



}
