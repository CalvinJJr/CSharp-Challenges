string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderID = orderStream.Split(',');
Array.Sort(orderID);
int i;

for (i = 0; i < orderID.Length; i++)
{
    if (orderID[i].Length != 4)
    {
        orderID[i] = orderID[i] + " - Error";
    }
    
    Console.WriteLine(orderID[i]);
}