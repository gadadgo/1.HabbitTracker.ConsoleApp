
using _1.HabbitTracker.ConsoleApp;
using System.ComponentModel.Design;
using static System.Formats.Asn1.AsnWriter;

Console.WriteLine("Please enter your name");

var name = Console.ReadLine();
var date = DateTime.UtcNow;
var games = new List<Game>();
var menu = new Menu();


menu.ShowMenu(name, date);

string GetName()
{
    Console.WriteLine("Please enter your name");
    var name = Console.ReadLine();
    return name;
}

Environment.Exit(0);
