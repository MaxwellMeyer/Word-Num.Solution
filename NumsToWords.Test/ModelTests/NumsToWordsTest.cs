using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumWord;


namespace NumWord.Tests
{
  [TestClass]
  public class NumWordTests
  {
    [TestMethod]
    public void NumToWord_ConvertsIntToString_ReturnsOneThroughNine()
    {
      List<string> expectations = new List<string> {
        "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"
      };

      for (int i = 0; i < expectations.Count; i++)
      {
        string expectation = expectations[i];
        Assert.AreEqual(expectation, Converter.NumToWord(i + 1));
      }
    }
    [TestMethod]
    public void NumToWord_ConvertsIntToString_ReturnsTeenWord()
    {
      List<string> expectations = new List<string> {
        "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
      };

      for (int i = 0; i < expectations.Count; i++)
      {
        string expectation = expectations[i];
        Assert.AreEqual(expectation, Converter.NumToWord(i + 11));
      }
    }

    [TestMethod]
    public void NumToWord_ConvertsIntToString_ReturnsTensPlaceWord()
    {
      List<string> expectations = new List<string> {
        "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
      };

      for (int i = 0; i < expectations.Count; i++)
      {
        string expectation = expectations[i];
        Assert.AreEqual(expectation, Converter.NumToWord((i + 1) * 10));
      }
    }
  }
}