using System.Collections.Generic;
using System;

namespace AnagramListChecker.Objects
{
  public class Anagram
  {
    public List<string> AnagramChecker(string input, List<string> wordsToCheck)
    {
      List<string> results = new List<string> {};
      char[] inputArray = input.ToCharArray();
      Array.Sort(inputArray);
      string sortedInput = string.Join("", inputArray);
      foreach (string word in wordsToCheck)
      {
        char[] wordArray = word.ToCharArray();
        Array.Sort(wordArray);
        string sortedWord = string.Join("", wordArray);

        if (sortedWord == sortedInput)
        {
          results.Add(word);
        }
      }
      return results;
    }
  }
}
