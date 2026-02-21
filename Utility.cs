using MathGame.Models;

namespace MathGame;

public class Utility
{
    private static List<Game> games = [];
    public static string GetName()
    {
        Console.Clear();
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine() ?? "";

        while (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Name cannot be empty.");
            name = Console.ReadLine() ?? "";
        }

        return name;
    }

    public static int[] GetNumbers()
    {
        var random = new Random();

        int firstNumber = random.Next(1, 10);
        int secondNumber = random.Next(1, 10);

        var numbers = new int[2];

        numbers[0] = firstNumber;
        numbers[1] = secondNumber;

        return numbers;
    }

    public static int[] GetDivisionNumbers()
    {
        var random = new Random();

        int firstNumber = random.Next(1, 101);
        int secondNumber = random.Next(1, 101);

        var numbers = new int[2];

        while (firstNumber % secondNumber != 0)
        {
            firstNumber = random.Next(1, 101);
            secondNumber = random.Next(1, 101);
        }

        numbers[0] = firstNumber;
        numbers[1] = secondNumber;

        return numbers;
    }

    public static string ValidateResult(string? result)
    {
        while (string.IsNullOrWhiteSpace(result) || !int.TryParse(result, out _))
        {
            Console.WriteLine("Your answer needs to be an integer number. Try again.");
            result = Console.ReadLine();
        }

        return result;
    }

    public static void AddToHistory(int score, GameType gameType)
    {
        games.Add(new Game
        {
            Score = score,
            Date = DateTime.Now,
            Type = gameType
        });
    }

    public static void GetGameHistory(string name)
    {
        Console.Clear();
        Console.WriteLine($"{name}'s Game History");
        Console.WriteLine("----------------------------------------");
        if (games.Count > 0)
        {
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts");
            }
        }
        else
            Console.WriteLine("There are no game records currently.");

        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }
}
