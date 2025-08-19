// Declare variables
string name = string.Empty;
int age = 0;
int retirementAge = 65;

// prompt user for input
Console.WriteLine("Enter your name: ");
name = Console.ReadLine();

Console.WriteLine("Your age? ");
age = Convert.ToInt32(Console.ReadLine()); // convert int

// process the data
int workingYearsRemaining = retirementAge - age;

// Output the result to user
Console.WriteLine($"So, your name is {name}");
Console.WriteLine($"Your age is {age}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");