//Validate String Challenge

using System.Runtime.CompilerServices;

Console.WriteLine(@"Please enter your role (Administrator, Manager, or User):");
string? readResult;
string verified = "Administrator, Manager, User";
string nextResult;
string cutResult;
string finalResult;


do
{

    readResult = Console.ReadLine();
    nextResult = readResult.ToLower();
    cutResult = nextResult.Trim();
    finalResult = cutResult;


    if (finalResult.Contains("administrator"))
    {
        Console.WriteLine("Your entry has been accepted.");
    }

        else if (finalResult.Contains("manager"))
        {
            Console.WriteLine("Your entry has been accepted.");
        }

            else if (finalResult.Contains("user"))
            {
                Console.WriteLine("Your entry has been accepted.");
            }

                else
                {
                    Console.WriteLine("Please enter a valid response.");
                }

}while(finalResult != verified);

        

