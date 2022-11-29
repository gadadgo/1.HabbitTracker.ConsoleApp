
using _1.HabbitTracker.ConsoleApp;
using System.ComponentModel.Design;
using static System.Formats.Asn1.AsnWriter;

Console.WriteLine("Please enter your name");

var name = Console.ReadLine();
var date = DateTime.UtcNow;
var games = new List<string>();
var menu = new Menu();

menu.ShowMenu(name, date);

string GetName()
{
    Console.WriteLine("Please enter your name");
    var name = Console.ReadLine();
    return name;
}

void GetGames()
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
void AddToHistory(int gameScore, string gameType)
{
    games.Add($"{DateTime.Now} - {gameType}: {gameScore}");
}

int[] GetDivisionNumbers()
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

Environment.Exit(0);
