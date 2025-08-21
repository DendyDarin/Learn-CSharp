// Welcome Message
Console.WriteLine("Welcome to simple calculator");
Console.WriteLine();

// Prompt for user input
Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// Show calculator option
Console.WriteLine();
Console.WriteLine("Operation's options:");
Console.WriteLine("1 - Addition");
Console.WriteLine("2 - Subtraction");
Console.WriteLine("3 - Multiply");
Console.WriteLine("4 - Division");
Console.WriteLine();
Console.Write("What do you want to operate? ");

int operation = Convert.ToInt32(Console.ReadLine());
int add = num1 + num2;
int sub = num1 - num2;
int mul = num1 * num2;
int div = num1 / num2;

switch (operation)
{
    case 1:
        Console.WriteLine($"The addition is {add}");
        break;
    case 2:
        Console.WriteLine($"The subtraction is {sub}");
        break;
    case 3:
        Console.WriteLine($"The multiply is {mul}");
        break;
    case 4:
        Console.WriteLine($"The division is {div}");
        break;
    default:
        Console.WriteLine("Invalid input operation.");
        break;
}

Console.WriteLine("Thank you using sample calculator.");