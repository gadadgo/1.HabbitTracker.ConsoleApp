//Part 6

Console.WriteLine("Please enter your name");

var name = Console.ReadLine();

var date = DateTime.UtcNow;



string introduction = $@"What game would you like to play? Choose below.
A - Addition
S - Subtraction
D - Division
M - Multiplication
Q - Quit the program";

Console.WriteLine($"Hello {name} it is {date.DayOfWeek} , welcome the the math game");
Console.WriteLine("/n");
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
        Exit();
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}

void MultiplicationGame()
{
    Console.WriteLine("Multiplication game is selected");
    int firstNumber;
    int secondNumber;

    int score = 0;

    for (int i = 0; i < 6; i++)
    {
        var random = new Random();
        firstNumber = random.Next(1, 10);
        secondNumber = random.Next(1, 10);
        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();
        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("The answer is correct");
            score++;
        }
        else
        {
            Console.WriteLine("The answer is wrong");
        }
        if (i == 5)
        {
            Console.WriteLine($"Game over, your score is {score}");
        }
    }
}

void DivisionGame()
{
    Console.WriteLine("Division game is selected");
    var random = new Random();
    int firstNumber = random.Next(1, 10);
    int secondNumber = random.Next(1, 10);
    Console.WriteLine($"{firstNumber} : {secondNumber}");
    var result = Console.ReadLine();
    if (int.Parse(result) == firstNumber / secondNumber)
    {
        Console.WriteLine("The answer is correct");
    }
    else
    {
        Console.WriteLine("The answer is wrong");
    }
}

void SubtractinGame()
{
    Console.WriteLine("Subtraction game is selected");
    int firstNumber;
    int secondNumber;

    int score = 0;

    for (int i = 0; i < 6; i++)
    {
        var random = new Random();
        firstNumber = random.Next(1, 10);
        secondNumber = random.Next(1, 10);
        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var result = Console.ReadLine();
        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("The answer is correct");
            score++;
        }
        else
        {
            Console.WriteLine("The answer is wrong");
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
        var random = new Random();
        firstNumber = random.Next(1, 10);
        secondNumber = random.Next(1, 10);
        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();
        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("The answer is correct");
            score++;
        }
        else
        {
            Console.WriteLine("The answer is wrong");
        }
        if (i == 5)
        {
            Console.WriteLine($"Game over, your score is {score}");
        }
    }
}

void Exit()
{
    Console.WriteLine("Goodbye");
    Environment.Exit(2);
}

Environment.Exit(0);
