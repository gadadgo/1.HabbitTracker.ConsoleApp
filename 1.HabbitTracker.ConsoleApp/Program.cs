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

if (gameSelected == "a")
{
    Console.WriteLine("Addition game is selected");
        }
else if (gameSelected == "s")
{
    Console.WriteLine("Subtraction game is selected");
}
else if (gameSelected == "d")
{
    Console.WriteLine("Division game is selected");
}
else if(gameSelected == "m")
{
    Console.WriteLine("Multiplication game is selected");
}
else
{
    Console.WriteLine("Goodbye");
}
Environment.Exit(0);
