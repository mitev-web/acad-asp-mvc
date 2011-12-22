using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a list of words, separated by spaces 
            //and prints the list in an alphabetical order.

            Console.WriteLine("Enter a some words separated by whitespace");
            string line = Console.ReadLine();
            line = line.Trim();
            List<string> words = new List<string>();
            words = line.Split(new string[] { " " }, StringSplitOptions.None).ToList();
            

            SortAlphabetical(words);
            Console.WriteLine("The alphabetically sorted words are:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

        }


        public static void SortAlphabetical(List<string> words)
        {
            List<char> alphabet = new List<char>{'a', 'b', 'c', 'd','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

            Console.WriteLine();
            string tempWord = "";
            for (int i = 0; i < words.Count-1; i++)
            {
                if(alphabet.IndexOf(words[i][0]) > alphabet.IndexOf(words[i+1][0])){
                    tempWord = words[i];
                    words[i] = words[i + 1];
                    words[i + 1] = tempWord;
                    SortAlphabetical(words);
                }
            }




        }
    }
}
