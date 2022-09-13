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

Console.WriteLine($"Hello {name} it is {date} , welcome the the math game");
Console.WriteLine(introduction);    

