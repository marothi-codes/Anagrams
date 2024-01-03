﻿/// <summary>
/// Checks whether two strings are Anagrams of each other
/// i.e., they contain the exact characters irrespective of order
/// </summary>
static bool IsAnagram(string stringA, string stringB, Exception argumentNullException)
{
    // Check if the input strings are null or whitespace
    if (string.IsNullOrWhiteSpace(stringA) || string.IsNullOrWhiteSpace(stringB))
    {
        throw argumentNullException;
    }

    // Make both strings lowercase for comparison purposes
    stringA = stringA.ToLower();
    stringB = stringB.ToLower();

    // Convert the strings to arrays of characters and then use OrderBy to sort them
    char[] sortedCharsStringA = stringA.ToCharArray().OrderBy(c => c).ToArray();
    char[] sortedCharsStringB = stringB.ToCharArray().OrderBy(c => c).ToArray();

    // Create new strings from the sorted characters
    string sortedStringA = new(sortedCharsStringA);
    string sortedStringB = new(sortedCharsStringB);

    // Return true if the strings contain the exact same characters, false otherwise
    return sortedStringA == sortedStringB;
}

// Get input string from user
Console.WriteLine("Enter string A:");
string? inputA = Console.ReadLine();

// Check if the input string is null or whitespace
if (string.IsNullOrWhiteSpace(inputA))
{
    Console.WriteLine("Input string A must not be null or whitespace");
    return;
}

Console.WriteLine("Enter string B");
string? inputB = Console.ReadLine();

// Check if the input string is null or whitespace
if (string.IsNullOrWhiteSpace(inputB))
{
    Console.WriteLine("Input string B must not be null or whitespace");
    return;
}

// Call the IsAnagram method and store the return value in a variable
bool result = IsAnagram(inputA, inputB, new ArgumentNullException("Input strings must not be null or whitespace"));

// Print the result to the console
Console.WriteLine(result ? "Is anagram" : "Is not anagram");

// Prompt the user to close the program
Console.WriteLine("Press any key to exit");
Console.ReadKey();
