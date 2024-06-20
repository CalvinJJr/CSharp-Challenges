string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal sum = 0m;
string remainder = "";

foreach (var i in values)
{
    decimal intValue; 
    if (decimal.TryParse(i, out intValue))
    {
        sum += intValue;
    }
    else
    {
        remainder += i;
    }
}

Console.WriteLine($"Remainder: {remainder}");
Console.WriteLine($"Sum: {sum}");