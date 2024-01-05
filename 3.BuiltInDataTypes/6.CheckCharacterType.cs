using System;

class Assignment36
{
    public void CheckCharacterType()
    {
      Console.WriteLine("Enter a lowercase character:");
        char inputChar = Console.ReadKey().KeyChar;

        if (char.IsLower(inputChar))
        {
            if (IsVowel(inputChar))
            {
                Console.WriteLine("\nIt is a lowercase vowel.");
            }
            else if (char.IsDigit(inputChar))
            {
                Console.WriteLine($"\nIt is a digit.");
            }
            else
            {
                Console.WriteLine($"\nIt is any other symbol.");
            }
        }
        else
        {
            Console.WriteLine("\nPlease enter a lowercase character.");
        }
    }

    static bool IsVowel(char ch)
    {
        // Check if the character is a vowel (a, e, i, o, or u)
        return "aeiou".Contains(ch);
    }

    
}