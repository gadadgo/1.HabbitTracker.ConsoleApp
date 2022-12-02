namespace _1.HabbitTracker.ConsoleApp;
internal class Helpers
{
   internal static List<Game> games = new();
    internal void GetGames()
    {
        Console.Clear();
        Console.WriteLine("Games history");
        foreach (var game in games)
        {
            Console.WriteLine(game);
        }
        Console.WriteLine("Press 'Enter' to continue");
        Console.ReadLine();
    }
    internal static void AddToHistory(int gameScore, string gameType)
    {
        games.Add(new Game
        {
            Date = DateTime.Now,
            Score = gameScore,
            Type = gameType
        });
    }
    internal int[] GetDivisionNumbers()
    {
        var random = new Random();
        var firstNumber = random.Next(1, 99);
        var secondNumber = random.Next(1, 99);
        var result = new int[2];

        while (firstNumber % secondNumber != 0)
        {
            firstNumber = random.Next(1, 99);
            secondNumber = random.Next(1, 99);
        }

        result[0] = firstNumber;
        result[1] = secondNumber;

        return result;
    }
}
