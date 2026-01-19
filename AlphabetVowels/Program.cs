using System;
namespace AlphabetVowels;

class Program
{
    public static void Main()
    {
    Console.WriteLine("Enter the first word: ");
    string firstWord=Console.ReadLine();
    Console.WriteLine("Enter the second word: ");
    string secondWord=Console.ReadLine();

    firstWord = firstWord.ToLower();
    secondWord = secondWord.ToLower();
    

    Alphabets alphabetObj=new Alphabets();
    alphabetObj.Comparision(firstWord,secondWord);



    }
    
}