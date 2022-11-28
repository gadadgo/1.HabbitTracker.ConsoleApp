using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.HabbitTracker.ConsoleApp
{
    internal class Menu
    {
        internal void ShowMenu(string name, DateTime date)
        {
            string introduction = $@"What game would you like to play? Choose below.
V - View score history
A - Addition
S - Subtraction
D - Division
M - Multiplication
Q - Quit the program";

            Console.WriteLine($"Hello {name} it is {date.DayOfWeek} , welcome the the math game");


            Console.WriteLine("------------------------------------");

            var isGameOn = true;

            do
            {
                Console.WriteLine(introduction);

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        GetGames();
                        break;
                    case "a":
                        AdditionGame();
                        break;
                    case "s":
                        SubtractinGame();
                        break;
                    case "d":
                        DivisionGame();
                        break;
                    case "m":
                        MultiplicationGame();
                        break;
                    case "q":
                        Exit();
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (isGameOn);
        }
    }
}
