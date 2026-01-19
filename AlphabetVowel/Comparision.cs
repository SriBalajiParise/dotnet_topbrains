using System.Text;

namespace AlphabetVowels;

public class Alphabets
{
    public bool IsVowel(char letter)
    {
        return "aeiou".Contains(letter);
    }

    public void Comparision(string firstWord, string secondWord)
    {
        StringBuilder word = new StringBuilder();

        foreach (var ch in firstWord)
        {
            char lowerCh = char.ToLower(ch);

            if (IsVowel(lowerCh) || !secondWord.Contains(lowerCh))
            {
                word.Append(lowerCh);
            }
        }

        
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < word.Length; i++)
        {
            if (i == 0 || word[i] != word[i - 1])
            {
                result.Append(word[i]);
            }
        }

        Console.WriteLine(result.ToString());
    }
}
