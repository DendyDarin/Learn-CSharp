// Welcome Message
using System.Runtime.InteropServices.Marshalling;

Console.WriteLine("Welcome to simple calculator");
Console.WriteLine();

// Prompt for user input


// Show calculator option
Console.WriteLine();
Console.WriteLine("Operation's options (-1 to exit):");
Console.WriteLine("1 - Addition");
Console.WriteLine("2 - Subtraction");
Console.WriteLine("3 - Multiply");
Console.WriteLine("4 - Division");
Console.WriteLine("5 - Fibonacci sequence");
Console.WriteLine();
Console.Write("What do you want to operate? ");

int operation = Convert.ToInt32(Console.ReadLine());

// check the choice first
while (operation != -1)
{
    // prompt user input
    Console.Write("Enter first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    int answer = 0;

    switch (operation)
    {
        case 1:
            answer = num1 + num2;
            break;
        case 2:
            answer = num1 - num2;
            break;
        case 3:
            answer = num1 * num2;
            break;
        case 4:
            answer = num1 / num2;
            break;
        case 5:
            for (int i = num1; i <= num2; i++)
            {
                answer += i;
            }
            break;
        default:
            Console.WriteLine("Invalid input operation.");
            break;
    }

Console.WriteLine($"The result is {answer}");
Console.WriteLine("Please enter to continue");
Console.ReadLine();
Console.Clear(); // to clear screen

Console.WriteLine("Operation's options (-1 to exit):");
Console.WriteLine("1 - Addition");
Console.WriteLine("2 - Subtraction");
Console.WriteLine("3 - Multiply");
Console.WriteLine("4 - Division");
Console.WriteLine("5 - Fibonacci sequence");
Console.WriteLine();
Console.Write("What do you want to operate? ");

operation = Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine();
Console.WriteLine("Thank you using sample calculator.");