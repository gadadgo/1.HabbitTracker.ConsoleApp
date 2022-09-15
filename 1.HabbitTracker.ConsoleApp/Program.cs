//Part 6

Console.WriteLine("Please enter your name");

string name = Console.ReadLine();

var date = DateTime.UtcNow;

string introduction = $@"What game would you like to play? Choose below.
A - Addition
S - Subtraction
D - Division
M - Multiplication
Q - Quit the program";

Console.WriteLine($"Hello {name} it is {date.DayOfWeek} , welcome the the math game");
Console.WriteLine(introduction);

Console.WriteLine("------------------------------------");

var gameSelected = Console.ReadLine();

switch (gameSelected.Trim().ToLower())
{
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
        Console.WriteLine("Goodbye");
        Environment.Exit(2);
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}

void MultiplicationGame()
{
    Console.WriteLine("Multiplication game is selected");
}

void DivisionGame()
{
    Console.WriteLine("Division game is selected");
}

void SubtractinGame()
{
    Console.WriteLine("Subtraction game is selected");
}

void AdditionGame()
{
    Console.WriteLine("Addition game is selected");
}

Environment.Exit(0);
