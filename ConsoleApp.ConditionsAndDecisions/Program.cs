Console.WriteLine("********** Simple IF Statement **********");
// Prompt for input
Console.Write("Please enter student's grade: ");

int grade = Convert.ToInt32(Console.ReadLine());

// Decide pass or fail based on input
if (grade > 50 )
{
    Console.WriteLine("Pass!");
}
else
{
    Console.WriteLine("Fail...");
}

Console.WriteLine();
Console.WriteLine("********** IF, ELSE IF Statement **********");

if (grade < 0 || grade > 100)
{
    Console.WriteLine("Invalid value!");
}
else if (grade < 50)
{
    Console.WriteLine("Nilai: F");
}
else if (grade >= 50 && grade < 65)
{
    Console.WriteLine("Nilai: C-");
}
else if (grade >= 65 && grade < 75)
{
    Console.WriteLine("Nilai: C+");
}
else if (grade >= 75 && grade < 85)
{
    Console.WriteLine("Nilai: B");
}
else
{
    Console.WriteLine("A. Nice!");
}

Console.WriteLine("Thank you");

// TERNARY OPERATOR
Console.WriteLine("********** TERNARY OPERATOR **********");

string passStatus = grade < 50 ? "Pass" : "Fail";
Console.WriteLine();

// SWITCH STATEMENT
Console.WriteLine("********** SWITCH Statement **********");

Console.Write("What day is to day? ");
//Console.WriteLine("1 - Sunday");
//Console.WriteLine("2 - Monday");
//Console.WriteLine("3 - Tuesday");
//Console.WriteLine("4 - Wednesday (Hump Day!)");
//Console.WriteLine("5 - Thursday");
//Console.WriteLine("6 - Friday (TGIF!)");
//Console.WriteLine("7 - Saturday (Beach Day!)");

int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1: 
        Console.WriteLine("It's Sunday");
        break;
    case 2: 
        Console.WriteLine("It's Monday");
        break;
    case 3: 
        Console.WriteLine("It's Tuesday");
        break;
    case 4: 
        Console.WriteLine("Hump Day!");
        break;
    case 5: 
        Console.WriteLine("It's Thursday");
        break;
    case 6: 
        Console.WriteLine("TGIF!");
        break;
    case 7: 
        Console.WriteLine("Beach Day!");
        break;
    default:
        Console.WriteLine("Invalid input. Accept 1 - 7 number only.");
        break;
}