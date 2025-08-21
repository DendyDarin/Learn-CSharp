// Example - Print Hello World 10 times

//Console.WriteLine("Hello World");

//Console.Write("How many times you want to print that word? ");

//int answer = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Ok, FOR LOOP result:");

//for (int i = 0; i < answer; i++)
//{
//    Console.WriteLine("Hello World");
//}

// WHILE LOOP
//Console.WriteLine();
//Console.WriteLine("WHILE LOOP result:");

//int counter = 0;

//while (counter < answer)
//{
//    Console.WriteLine("Hello World");
//    counter++;
//}

// EXERCISE
// Ask the user for a number and find the total for each number. Print final sum when user enters -1 to exit.

int sum = 0;
int num = 0;

while (num != -1)
{
    Console.Write("Angka untuk dijumlah. (Masukkan -1 untuk menghitung total penjumlahan: ");
    num = Convert.ToInt32(Console.ReadLine());
    if (num != -1)
    {
        sum += num;
    }
}

Console.WriteLine($"Jumlah semuanya: {sum}");

// DO WHILE LOOP

Console.WriteLine("***** DO WHILE LOOP *****");
