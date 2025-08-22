// Write a program that takes a user's age and print to the screen. Display an error message if an invalid input is received.

try
{
    Console.Write("Enter your age: ");

    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Your age is: {age}");
}
catch (Exception)
{
    Console.WriteLine("Input value is incorrect.");
	//throw;
}
finally
{
    Console.WriteLine("Thank you.");
}

