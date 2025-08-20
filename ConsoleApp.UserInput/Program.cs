// Declare variables
string? firstName = string.Empty; // make it nullable with '?'
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;
decimal salary;
char gender = char.MinValue;
bool isWorking = true;

// prompt user for input
Console.Write("Enter your first name: ");
firstName = Console.ReadLine();

Console.Write("Your last name? ");
lastName = Console.ReadLine();

Console.Write("How about your age? ");
age = Convert.ToInt32(Console.ReadLine()); // convert int

Console.Write("Enter your salary as developer: ");
salary = Convert.ToInt32(Console.ReadLine());

Console.Write("What is your gender? (M/F) ");
gender = Convert.ToChar(Console.ReadLine()); // convert char

Console.Write("Are you still working on? (true/false) ");
isWorking = Convert.ToBoolean(Console.ReadLine()); // convert bool

// process the data
int workingYearsRemaining = retirementAge - age;

// Output the result to user
Console.WriteLine($"So, your name is {firstName} {lastName}");
Console.WriteLine($"Your age is {age}");
Console.WriteLine($"Well, your salary is: ${salary}");
Console.WriteLine($"Your gender is: {gender}");
Console.WriteLine($"Still working on? {isWorking}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");