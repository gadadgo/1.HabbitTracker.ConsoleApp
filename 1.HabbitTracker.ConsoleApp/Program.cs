//Part 6

Console.WriteLine("Please enter your name");

string name = Console.ReadLine();

var date = DateTime.UtcNow;

string introduction = $@"hat game would you like to play? Choose below.
A - Addition
S - Subtraction
D - Division
M - Multiplication
Q - Quit the program";

Console.WriteLine($"Hello {name} it is {date.DayOfWeek} , welcome the the math game");
Console.WriteLine(introduction);

Console.WriteLine("------------------------------------");

var gameSelected = Console.ReadLine();

if (gameSelected.Trim().ToLower() == "a")
{
    AdditionGame();
}
else if (gameSelected.Trim().ToLower() == "s")
{
    SuntractinGame();
}
else if (gameSelected.Trim().ToLower() == "d")
{
    DivisionGame();
}
else if (gameSelected.Trim().ToLower() == "m")
{
    MultiplicationGame();
}
else
{
    Console.WriteLine("Goodbye");
}

void MultiplicationGame()
{
    Console.WriteLine("Multiplication game is selected");
}

void DivisionGame()
{
    Console.WriteLine("Division game is selected");
}

void SuntractinGame()
{
    Console.WriteLine("Subtraction game is selected");
}

void AdditionGame()
{
    Console.WriteLine("Addition game is selected");
}

Environment.Exit(0);
