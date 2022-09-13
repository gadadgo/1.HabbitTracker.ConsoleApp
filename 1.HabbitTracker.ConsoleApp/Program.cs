string name = "Bob";
int index = 1;
char initail = 'B';
decimal height = 1.88m;
bool alive = true;


var myParagraph = @$"These are the most common data types:
{index++}  - String, example {name}
{index++}  - Char, example {initail}
{index++}  - Int, example {6}
{index++}  - Decimal, example {height}
{index++}  - Bool, example {alive}";

Console.WriteLine(myParagraph);
Console.ReadLine();

