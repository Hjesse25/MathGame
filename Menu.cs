using Microsoft.VisualBasic;

namespace MathGame;

public class Menu
{
    GameEngine game = new();
    public void ShowMenu(string name, DateTime date)
    {
        Console.WriteLine($"Hello {name}. It's {date}. Welcome to the Math Game. Glad to see that you want to improve your math skills.");
        Console.WriteLine("Press any key to go to the main menu...");
        Console.ReadLine();

        bool isGameOn = true;

        do
        {
            Console.Clear();
            Console.WriteLine("Which game would you like to play today? Choose from the options below:");
            Console.WriteLine("A - Addition");
            Console.WriteLine("S - Subtraction");
            Console.WriteLine("M - Multiplication");
            Console.WriteLine("D - Division");
            Console.WriteLine("V - View previous games");
            Console.WriteLine("Q - Quit the program");

            var userChoice = Console.ReadLine() ?? "";

            switch (userChoice.Trim().ToUpper())
            {
                case "A":
                    game.AdditionGame("Addition Game");
                    break;
                case "S":
                    break;
                case "M":
                    break;
                case "D":
                    break;
                case "V":
                    Utility.GetGameHistory(name);
                    break;
                case "Q":
                    isGameOn = false;
                    Console.WriteLine("Goodbye");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select from the following options.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        } while (isGameOn);
    }
}
