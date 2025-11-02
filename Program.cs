



using System.Security.Cryptography.X509Certificates;

using System;
using System.Collections.Generic;


while (true)
{
    Dictionary<char, char> Encryption = new Dictionary<char, char>()
        {
            { 'a', '"' }, { 'b', '1' }, { 'c', '¤' }, { 'd', '%' },
            { 'e', '¤' }, { 'f', '&' }, { 'g', '/' }, { 'h', '=' },
            { 'i', '?' }, { 'j', ')' }, { 'k', '>' }, { 'l', '<' },
            { 'm', '>' }, { 'n', '"' }, { 'o', '#' }, { 'p', '^' },
            { 'q', '*' }, { 'r', '%' }, { 's', '-' }, { 't', '_' },
            { 'u', '.' }, { 'v', ';' }, { 'w', ';' }, { 'x', '^' },
            { 'y', '*' }, { 'z', '(' }
        };

    Random rand = new Random();
    string specialChars = "!@#$%&*()_+-=<>?/|[]{},.";

    Console.Write("Enter your text: ");
    string userText = Console.ReadLine().ToLower();

    string encryptedText = "";

    foreach (char c in userText)
    {

        if (c == ' ')
        {
            encryptedText += ' ';
            continue;
        }


        if (!Encryption.ContainsKey(c))
        {
            char newSymbol;


            do
            {
                newSymbol = specialChars[rand.Next(specialChars.Length)];
            } while (Encryption.ContainsValue(newSymbol));

            Encryption.Add(c, newSymbol);
        }

        encryptedText += Encryption[c];
    }

    Console.WriteLine("\nEncrypted Text: " + encryptedText);

    // Console.WriteLine("\nEncryption Dictionary:");
    //foreach (var pair in Encryption)
    {
        // Console.WriteLine($"{pair.Key} => {pair.Value}");
    }

    Console.ReadLine();
    { }
}










