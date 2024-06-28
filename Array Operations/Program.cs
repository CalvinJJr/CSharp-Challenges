using System.Security.Cryptography;

string pangram = "The quick brown fox jumps over the lazy dog";
string[] pangram1 = pangram.Split(' ');
string[] pangram2 = new string[pangram1.Length];

for (int i = 0; i < pangram1.Length; i++)
{
    char[] pangram3 = pangram1[i].ToCharArray();
    Array.Reverse(pangram3);
    pangram2[i] = new string(pangram3);
}

string final = String.Join(" ", pangram2);
Console.WriteLine(pangram);
Console.WriteLine(final);