using MathGame.Models;

namespace MathGame;

public class GameEngine
{
    public void AdditionGame(string message)
    {
        int score = 0;

        for (var i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var numbers = Utility.GetNumbers();
            var firstNumber = numbers[0];
            var secondNumber = numbers[1];

            var result = DisplayAndGetResult(firstNumber, secondNumber, GameType.Addition);

            if (Convert.ToInt32(result) == firstNumber + secondNumber)
            {
                Console.WriteLine("Your answer was correct. Press any key for the next question.");
                score += 1;
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect. Press any key for the next question.");
                Console.ReadKey();
            }
        }

        Console.WriteLine($"Game is done. Your score is {score}.");
        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();

        Utility.AddToHistory(score, GameType.Addition);
    }

    public void SubtractionGame(string message)
    {
        int score = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var numbers = Utility.GetNumbers();
            var firstNumber = numbers[0];
            var secondNumber = numbers[1];

            var result = DisplayAndGetResult(firstNumber, secondNumber, GameType.Subtraction);

            if (Convert.ToInt32(result) == firstNumber - secondNumber)
            {
                Console.WriteLine("Your answer was correct. Press any key for the next question.");
                score += 1;
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect. Press any key for the next question.");
                Console.ReadKey();
            }
        }

        Console.WriteLine($"Game is done. Your score is {score}.");
        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();

        Utility.AddToHistory(score, GameType.Subtraction);
    }

    public void MultiplicationGame(string message)
    {
        int score = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var numbers = Utility.GetNumbers();
            var firstNumber = numbers[0];
            var secondNumber = numbers[1];

            var result = DisplayAndGetResult(firstNumber, secondNumber, GameType.Multiplication);

            if (Convert.ToInt32(result) == firstNumber * secondNumber)
            {
                Console.WriteLine("Your answer was correct. Press any key for the next question.");
                score += 1;
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect. Press any key for the next question.");
                Console.ReadKey();
            }
        }

        Console.WriteLine($"Game is done. Your score is {score}.");
        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();

        Utility.AddToHistory(score, GameType.Multiplication);
    }

    public void DivisionGame(string message)
    {
        int score = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var numbers = Utility.GetDivisionNumbers();
            var firstNumber = numbers[0];
            var secondNumber = numbers[1];

            var result = DisplayAndGetResult(firstNumber, secondNumber, GameType.Division);

            if (Convert.ToInt32(result) == firstNumber / secondNumber)
            {
                Console.WriteLine("Your answer was correct. Press any key for the next question.");
                score += 1;
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect. Press any key for the next question.");
                Console.ReadKey();
            }
        }

        Console.WriteLine($"Game is done. Your score is {score}.");
        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();

        Utility.AddToHistory(score, GameType.Division);
    }

    private string DisplayAndGetResult(int firstNumber, int secondNumber, GameType gameType)
    {
        if (gameType == GameType.Addition)
            Console.WriteLine($"{firstNumber} + {secondNumber} = ??");
        else if (gameType == GameType.Subtraction)
            Console.WriteLine($"{firstNumber} - {secondNumber} = ??");
        else if (gameType == GameType.Multiplication)
            Console.WriteLine($"{firstNumber} * {secondNumber} = ??");
        else if (gameType == GameType.Division)
            Console.WriteLine($"{firstNumber} / {secondNumber} = ??");

        var result = Console.ReadLine() ?? "";
        result = Utility.ValidateResult(result);
        return result;
    }
}
