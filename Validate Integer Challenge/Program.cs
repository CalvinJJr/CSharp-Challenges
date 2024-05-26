string? readInput;
int userInput = 0;
Console.WriteLine("Please enter a number between 5 and 10.");

do
{
    readInput = Console.ReadLine();
    int.TryParse(readInput, out userInput);

    if (userInput < 5 )
    {
        Console.WriteLine("The number that you've entered is invalid, please try again.");
    }
    else if (userInput > 10)
        {
            Console.WriteLine("The number that you've entered is invalid, please try again.");
        }
        else
            {
                Console.WriteLine("Your value has been accepted, thank you!");
            }
}
while (userInput > -1);
    readInput = Console.ReadLine();
        

