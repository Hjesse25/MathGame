namespace MathGame;

public class GameEngine
{
    public void AdditionGame(string message)
    {
        var score = 0;

        for (var i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var numbers = Utility.GetNumbers();
            var firstNumber = numbers[0];
            var secondNumber = numbers[1];

            Console.WriteLine($"{firstNumber} + {secondNumber} = ??");
            var result = Console.ReadLine() ?? "";
            result = Utility.ValidateResult(result);

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

            if (i == 4)
                break;
        }

        Console.WriteLine($"Game is done. Your score is {score}.");
        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();

        Utility.AddToHistory(score, Models.GameType.Addition);
    }
}
