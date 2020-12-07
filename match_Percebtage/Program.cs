using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace match_Percebtage
{
    class Program
    {
        static void Main()
        {
            // Get sentences
            Console.WriteLine("input sentence 1");
            string sentence1 = Console.ReadLine();
            Console.WriteLine("input sentence 2");
            string sentence2 = Console.ReadLine();
            // Call Check percentage function, this will do all the work
            CheckMatchPercentage(sentence1, sentence2);

        }

        static string[] GetWords(string fPath) // this function expects a string path to the simpple words text file
        {
            var fpath = fPath; // had to do this to use that variable in this function, idk why.
            string[] allSimpleWords = File.ReadAllText(fpath).Split(); // read the simple words and then split them into an array
            return allSimpleWords; // Return the array or simple words, so when you call get words you get an array of simple words
        }

        static string[] RemoveSimpleWords(string[] words) // This function expects an array of strings when called, each sentence will be brought in here
        {
            List<string> listWords = words.ToList(); // C# you can't add or delete items of an array so i type-casted array of incoming sentence to a list

            string path = Directory.GetCurrentDirectory(); // This gets the current directory without a slash on the end
            string fPath = path + @"\simple_words.txt"; // This is the full path to the text file in the current directory

            string[] listOfSimpleWords = GetWords(fPath); // calls getWords and saves array of simple words in variable

            foreach(string simpleWord in listOfSimpleWords) //for each simple word...
            {
                for (var i=0; i<listWords.Count; i++) // Use this for loop to check every word of the current sentence against the simple word we are currently looking at
                {
                    if (listWords[i].ToLower() == simpleWord.ToLower()) // Check every word of the current sentence against the simple word we are currently looking at
                    {
                        listWords.Remove(listWords[i]); // Remove the words that match
                    }
                }

                }
            return listWords.ToArray(); // After all the operations are done we typwcast the list back to an array and return the array
        }


        static void CheckMatchPercentage(string s1, string s2) // This is the main function that brings everything together
        {
            string mainString;
            string otherString;
            double matchPercentage = 0.0;
            // double percentOfWordsMatched;

            if (s1.Length > s2.Length) // This if statement finds the longer of the two sentences, I use the longer as the main sentence
            {
                mainString = s1;
                otherString = s2;
            }
            else
            {
                mainString = s2;
                otherString = s1;
            }

            //split into words array & remove simple words that don't add to story
            string[] listOfMainString = RemoveSimpleWords(mainString.Split());
            string[] listOfOtherString = RemoveSimpleWords(otherString.Split());

            double mainWordWorth = Math.Round((100.0 / listOfMainString.Length), 2); // Find how much percentage one word is worth
            foreach (var mainWord in listOfMainString) // So we choose one main word at a time
            {
                foreach (var otherWord in listOfOtherString) // While we have a main word we take all the other string words and checks to see if it matched the main word we are looking at
                {
                    if (otherWord.ToLower() == mainWord.ToLower()) // If it matches...
                    {
                        matchPercentage = matchPercentage + mainWordWorth; // Add up the percent that matches
                        Console.WriteLine($"{otherWord} = {matchPercentage}"); // Print each word as it matches and give an updated score
                    }
                }
            }
            Console.WriteLine($"Percentage Match = {Math.Round(matchPercentage)}%"); // This prints the ultimate result after everything is added up
            if(matchPercentage >= 30) // This works for my needs
            {
                Console.WriteLine("This is probably a match");
            }
            else
            {
                Console.WriteLine("This is probably NOT a match");
            }

            Main(); // Calls main to have the program loop until you exit it (Testing purposes)

        }
    }
}
