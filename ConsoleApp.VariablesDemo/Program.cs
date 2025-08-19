// Different Data Types
/*
    text - string
    integer - int
    decimal - double, floa, decimal
    logical - bool
*/

string name = "Denz";
string city = "Cirebon";
string age = "48";

Console.WriteLine(name);
Console.WriteLine("I am " + name); // string concatenation
Console.WriteLine($"From {city}"); // string interpolation
Console.WriteLine("I am {0} years old", age); // formatted string

int umur = 48;

Console.WriteLine(umur);
Console.WriteLine("Umurku " + umur);

bool isAmazing = true;
Console.WriteLine("Am I amazing? " + isAmazing);