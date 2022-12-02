namespace _1.HabbitTracker.ConsoleApp;
internal class Menu
{
    GameEngine gameEngine = new(); 
    Helpers helpers = new Helpers();
    internal void ShowMenu(string name, DateTime date)
    {
        string introduction = $@"What game would you like to play? Choose below.
V - View score history
A - Addition
S - Subtraction
D - Division
M - Multiplication
Q - Quit the program";

        Console.WriteLine($"Hello {name} it is {date.DayOfWeek} , welcome the the math game");

        Console.WriteLine("------------------------------------");

        var isGameOn = true;

        do
        {
            Console.WriteLine(introduction);

            var gameSelected = Console.ReadLine();

            switch (gameSelected.Trim().ToLower())
            {
                case "v":
                    helpers.GetGames();
                    break;
                case "a":
                    gameEngine.AdditionGame();
                    break;
                case "s":
                    gameEngine.SubtractinGame();
                    break;
                case "d":
                    gameEngine.DivisionGame();
                    break;
                case "m":
                    gameEngine.MultiplicationGame();
                    break;
                case "q":
                    gameEngine.Exit();
                    isGameOn = false;
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        } while (isGameOn);
    }
}
