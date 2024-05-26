//If - Else If Challenge

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage1 = 10;
int discountPercentage2 = 20;

if (daysUntilExpiration <= 10)
{
    if ((daysUntilExpiration <= 5) && (daysUntilExpiration > 1 ))
    {
        {
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage1}%!");
        }
    }
        else if (daysUntilExpiration == 1) 
        
            { 
                {
                    Console.WriteLine($"Your subscription expires within a day! Renew now and save {discountPercentage2}%!");
                }

            }
            else if ( daysUntilExpiration == 0) 
                {
                    Console.WriteLine("Your subscription has expired.");
                } 
    else
    {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
}
