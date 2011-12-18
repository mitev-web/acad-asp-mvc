using System;
using System.Collections.Generic;
using System.Linq;

class ProjectionExample
{
    static void Main()
    {
        string[] sentences = new string[] {
            "The quick brown", 
            "fox jumped over",
            "the lazy dog"};

        // Select returns a three string[]
        IEnumerable<string[]> firstWords = sentences.Select(sentence => sentence.Split(' '));

        // To get each word, we have to use two foreach loops
        foreach (string[] segment in firstWords)
        {
            foreach (string word in segment)
            {
                Console.WriteLine(word);
            }
        }
        Console.WriteLine();

        // SelectMany returns nine strings (sub-iterates the Select result)
        IEnumerable<string> secondWords = sentences.SelectMany(sentence => sentence.Split(' '));

        // With SelectMany we have every string individually
        foreach (var word in secondWords)
        {
            Console.WriteLine(word);
        }
        Console.WriteLine();

        IEnumerable<string> thirdWords =
        from segment in sentences
        from word in segment.Split(' ')
        select word;
        // With SelectMany we have every string individually
        foreach (var w in thirdWords)
        {
            Console.WriteLine(w);
        }
    }
}
