# match_Percentage
This is part of a larger project, decided to share.
This code takes two sentences and compares them to see how closely matched they are.
This is my own code and it works perfectly for my uses.

I originally wrote this to compare title headlines from local news websites I web scrape.
On any given day, all the websites can have the same story with the title being very similar, which helps me check for duplicate articles.
A 30% match works for me.
There are comments explaining most things in the code.
contact: kentaylorappdev@gmail.com

Project Name: Match Percentage

Description:
This C# project compares the similarity between two sentences and calculates the matching percentage. It is designed to help identify duplicate articles by comparing the title headlines from local news websites, where similar stories may have nearly identical titles. This project provides a simple and effective way to check for duplicate content.

Usage:
1. Run the program.
2. Enter the first sentence when prompted.
3. Enter the second sentence when prompted.
4. The program will calculate the matching percentage between the two sentences and display the result.
5. If the matching percentage is equal to or greater than 30%, it indicates a probable match between the sentences.

Functions:
1. GetWords(string fPath):
   - Description: Reads a text file containing simple words and returns an array of those words.
   - Parameters:
     - fPath: The file path to the simple words text file.
   - Returns: An array of simple words.

2. RemoveSimpleWords(string[] words):
   - Description: Removes simple words from a given array of words (sentence).
   - Parameters:
     - words: An array of strings representing a sentence.
   - Returns: An array of words with simple words removed.

3. CheckMatchPercentage(string s1, string s2):
   - Description: Compares two sentences and calculates the matching percentage.
   - Parameters:
     - s1: The first sentence to compare.
     - s2: The second sentence to compare.
   - Returns: None.

Main Method:
The Main method acts as the entry point of the program. It prompts the user to input two sentences and calls the CheckMatchPercentage function to calculate the matching percentage.

Contact:
For any questions or inquiries, please contact kentaylorappdev@gmail.com.

