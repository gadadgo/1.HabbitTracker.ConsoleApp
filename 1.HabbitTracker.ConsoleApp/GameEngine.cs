namespace _1.HabbitTracker.ConsoleApp;

internal class GameEngine
{
    Helpers helpers = new Helpers();
    internal void MultiplicationGame()
    {
        int firstNumber;
        int secondNumber;

        int score = 0;

        for (int i = 0; i < 6; i++)
        {
            Console.Clear();
            Console.WriteLine("Multiplication game");
            var random = new Random();
            firstNumber = random.Next(1, 10);
            secondNumber = random.Next(1, 10);
            Console.WriteLine($"{firstNumber} * {secondNumber}");
            var result = Console.ReadLine();
            if (int.Parse(result) == firstNumber * secondNumber)
            {
                Console.WriteLine("The answer is correct, press 'Enter' button to continue");
                Console.ReadLine();
                score++;
            }
            else
            {
                Console.WriteLine("The answer is wrong, press 'Enter' button to continue");
                Console.ReadLine();
            }
            if (i == 5)
            {
                Console.WriteLine($"Game over, your score is {score}");
            }
        }
        Helpers.AddToHistory(score, "Multiplication");
    }

    internal void DivisionGame()
    {
        Console.WriteLine("Division game");
        var score = 0;
        for (int i = 0; i < 6; i++)
        {
            Console.Clear();
            var divisionNumbers = helpers.GetDivisionNumbers();
            var firstNumber = divisionNumbers[0];
            var secondNumber = divisionNumbers[1];

            Console.WriteLine($"{firstNumber} / {secondNumber}");
            var result = Console.ReadLine();
            if (int.Parse(result) == firstNumber / secondNumber)
            {
                Console.WriteLine("The answer is correct, press 'Enter' to continue");
                Console.ReadLine();
                score++;
            }
            else
            {
                Console.WriteLine("The answer is wrong, press 'Enter' to continue");
                Console.ReadLine();
            }
            if (i == 5)
            {
                Console.WriteLine($"Game over! Your score is {score}");
            }
        }
        Helpers.AddToHistory(score, "Division");
    }

    internal void SubtractinGame()
    {
        Console.WriteLine("Subtraction game");
        int firstNumber;
        int secondNumber;

        int score = 0;

        for (int i = 0; i < 6; i++)
        {
            Console.Clear();
            var random = new Random();
            firstNumber = random.Next(1, 10);
            secondNumber = random.Next(1, 10);
            Console.WriteLine($"{firstNumber} - {secondNumber}");
            var result = Console.ReadLine();
            if (int.Parse(result) == firstNumber - secondNumber)
            {
                Console.WriteLine("The answer is correct, press 'Enter' to continue");
                Console.ReadLine();
                score++;
            }
            else
            {
                Console.WriteLine("The answer is wrong, press 'Enter' to continue");
                Console.ReadLine();
            }
            if (i == 5)
            {
                Console.WriteLine($"Game over, your score is {score}");
            }
        }
        Helpers.AddToHistory(score, "Subtraction");
    }

    internal void AdditionGame()
    {
        Console.WriteLine("Addition game is selected");

        int firstNumber;
        int secondNumber;

        int score = 0;

        for (int i = 0; i < 6; i++)
        {
            Console.Clear();
            var random = new Random();
            firstNumber = random.Next(1, 10);
            secondNumber = random.Next(1, 10);
            Console.WriteLine($"{firstNumber} + {secondNumber}");
            var result = Console.ReadLine();
            if (int.Parse(result) == firstNumber + secondNumber)
            {
                Console.WriteLine("The answer is correct, press 'Enter' to continue");
                Console.ReadLine();
                score++;
            }
            else
            {
                Console.WriteLine("The answer is wrong, press 'Enter' to continue");
                Console.ReadLine();
            }
            if (i == 5)
            {
                Console.WriteLine($"Game over, your score is {score}");
            }
        }

        Helpers.AddToHistory(score, "Addition");
    }

    internal void Exit()
    {
        Console.WriteLine("Goodbye");
        Environment.Exit(2);
    }

}
