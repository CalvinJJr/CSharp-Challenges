using System.Formats.Asn1;
using System.Net;

Random random = new Random();
int attack = random.Next(1, 11);
int theHero = 10;
int theMonster = 10;

do 
{
    attack = random.Next(1, 11);
    theMonster -= attack;

    {
        Console.WriteLine($"The Hero attacks the Monster and deals {attack} damage. The Monster now has {theMonster} health remaining.");
    }

    if (theMonster <= 0) continue;

    if (theMonster !=0 && theHero > 0)
    {
        attack = random.Next(1, 11);
        theHero -= attack;
        Console.WriteLine($"The Monster attacks the Hero and deals {attack} damage. The Hero now has {theHero} health remaining.");
    }
            
}

while (theMonster > 0 && theHero > 0);
{
    Console.WriteLine(theHero > theMonster ? "The Monster has slain the Hero!" : "The Hero has slain the Monster!");
}

