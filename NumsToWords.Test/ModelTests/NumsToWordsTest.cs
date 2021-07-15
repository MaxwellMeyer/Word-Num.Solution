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
  }
}