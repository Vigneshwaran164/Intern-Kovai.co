
using System;

namespace intern_task.oops;

class Dictionary
{
    static void Main (string[] args)
    {
        //program to find the frequency of characters using dictionary
        Console.WriteLine("Enter the word to count the frequency of it :");
        string word = Console.ReadLine();

        //initializing the dictionary
        Dictionary <char,int> frequency = new Dictionary<char,int>();

        foreach(char character in word )
        {
            if(frequency.ContainsKey(character))
            {
                //increamenting the frequency of the repeated character
                frequency[character]++;

            }
            else
            {
                //adding the first occurence of the character in the dictionary
                frequency.Add(character,1);

            }

        }
        //iterating over the elements in the dictionary
        
        foreach(var keyValuePair in frequency)
        {
            Console.WriteLine($"The frequency of {keyValuePair.Key} is {keyValuePair.Value}");
        }


    }
}