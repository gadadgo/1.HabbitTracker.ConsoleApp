//Math game 

Console.WriteLine("Please enter your name");

var name = Console.ReadLine();
var date = DateTime.UtcNow;

var games = new List<string>();

Menu(name);

void Menu(string? name)
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
                GetGames();
                break;
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
                Exit();
                isGameOn = false;
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }while(isGameOn);
}

void GetGames()
{
    Console.Clear();
    Console.WriteLine("Games history");
    foreach(var game in games)
    {
        Console.WriteLine(game);
    }
    Console.WriteLine("Press 'Enter' to continue");
}

void MultiplicationGame()
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
}

void DivisionGame()
{
    Console.WriteLine("Division game");
    var score = 0;
    for (int i = 0; i < 6; i++)
    {
        Console.Clear();
        var divisionNumbers = GetDivisionNumbers();
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
}

void SubtractinGame()
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
}

void AdditionGame()
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

    games.Add($"{DateTime.Now} - Addition = {score}");
}

void Exit()
{
    Console.WriteLine("Goodbye");
    Environment.Exit(2);
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
