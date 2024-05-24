//Creating a squaring program

static void mySquare()
{
    Console.WriteLine("Please enter a number to square:");
    
    int square = Convert.ToInt16(Console.ReadLine());
    int squared = square * square;

    Console.WriteLine($"Your number is: {squared} squared!");
}

mySquare();