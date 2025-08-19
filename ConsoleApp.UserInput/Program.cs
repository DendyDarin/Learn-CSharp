// Declare variables
string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;

// prompt user for input
Console.WriteLine("Enter your first name: ");
firstName = Console.ReadLine();

Console.WriteLine("Your last name? ");
lastName = Console.ReadLine();

Console.WriteLine("How about your age? ");
age = Convert.ToInt32(Console.ReadLine()); // convert int

// process the data
int workingYearsRemaining = retirementAge - age;

// Output the result to user
Console.WriteLine($"So, your name is {name}");
Console.WriteLine($"Your age is {age}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");