using System.Collections.Generic;
using System;
using Xunit;
namespace AnagramListChecker.Objects
{
  public class AnagramTest
  {
    [Fact]
    public void AnagramChecker_userInputTwoWords_OutputOneWord()
    {
    //Arrange
    List <string> expectedResult = new List<string> {"beard"};
    List <string> listToTest = new List<string>{"beard"};
    Anagram newAnagram = new Anagram();

    //Act
    List <string> result = newAnagram.AnagramChecker("bread", listToTest);

    //Assert
    Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void AnagramChecker_userInputManyWords_OutputAnagramWords()
    {
    //Arrange
    List <string> expectedResult = new List<string> {"beard", "bared"};
    List <string> listToTest = new List<string>{"beard", "bared", "beer", "bird", "banana"};
    Anagram newAnagram = new Anagram();

    //Act
    List <string> result = newAnagram.AnagramChecker("bread", listToTest);

    //Assert
    Assert.Equal(expectedResult, result);
    }
  }
}
