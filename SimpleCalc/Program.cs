using System.Linq.Expressions;

int addition(int a, int b)
{
    return a + b;
}

int subtraction(int a, int b)
{
    return a - b;
}

int multiplication(int a, int b)
{
    return a * b;
}

Console.WriteLine("Input the first number: ");
var a = Console.ReadLine();
Console.WriteLine("Input the second number: ");
var b = Console.ReadLine();
int c = 0;

int number1 = int.Parse(a);
int number2 = int.Parse(b);


Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]ddition?");
Console.WriteLine("[S]ubtraction?");
Console.WriteLine("[M]ultiplication?");

var operation = Console.ReadLine();

if (operation == "A" || operation == "a")
{
    c = addition(number1, number2);
    Console.WriteLine(c);
}
else if (operation == "S" || operation == "s")
{
    c = subtraction(number1, number2);
    Console.WriteLine(c);
}
else if (operation == "M" || operation == "m")
{
    c = multiplication(number1, number2);
    Console.WriteLine(c);
}
else
{
    Console.WriteLine("Something went wrong.");
}
