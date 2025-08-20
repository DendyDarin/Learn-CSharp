
// option 1 to get input
Console.Write("First number? ");
int num1 = Convert.ToInt32(Console.ReadLine());

// option 2
int num2 = 0;
Console.Write("Second number? ");
string numberEntered = Console.ReadLine();
num2 = Convert.ToInt32(numberEntered);

/*
    Math Operations and operator
 */
// add number
int sum = num1 + num2;

// multiply
int product = num1 * num2;

// division
int quotient = num1 / num2;

// subtraction
int diff = num1 - num2;

// modulus
int mod = num1 % num2;

Console.WriteLine();
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Diff: {diff}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine();

/*
    Logic operation
 */
bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo  = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo = num1 <= num2;
bool isNotEqualTo  = num1 != num2;

Console.WriteLine($"Is {num1} greater than {num2}? {isGreaterThan}");
Console.WriteLine($"Is {num1} less than {num2}? {isLessThan}");
Console.WriteLine($"Is {num1} equal to {num2}? {isEqualTo}");
Console.WriteLine($"Is {num1} greater than or equal to {num2}? {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is {num1} less than or equal to {num2}? {isLessThanOrEqualTo}");
Console.WriteLine($"Is {num1} not equal to {num2}? {isGreaterThan}");
Console.WriteLine();

/*
    Assignment operator
*/

Console.Write("Ok, now pick a random value: ");
int randomValue = Convert.ToInt32(Console.ReadLine());

num1 += randomValue;
Console.WriteLine($"Your first number increased by {randomValue}: {num1}");

num1 -= 3;
Console.WriteLine($"Your num1 reduced by 3 is now: {num1}");

num1 /= 2;
Console.WriteLine($"Your num1 devided by 2 is now: {num1}");

num1 %= 2;
Console.WriteLine($"Your num1 modulus by 2 is now: {num1}");

num1 *= 10;
Console.WriteLine($"Your num1 multiplied by 10 is now: {num1}");
