using System;
using System.Collections.Generic;

namespace NumWord
{
  public class Converter
  {
    public static Dictionary<int, string> numWords = new Dictionary<int, string>()
    {
      {1,"one"},
      {2,"two"},
      {3,"three"},
      {4,"four"},
      {5,"five"},
      {6,"six"},
      {7,"seven"},
      {8,"eight"},
      {9,"nine"},
      {10,"ten"},
      {11,"eleven"},
      {12,"twelve"},
      {13,"thirteen"},
      {14,"fourteen"},
      {15,"fifteen"},
      {20, "twenty"},
      {30, "thirty"},
      {40, "forty"},
      {50, "fifty"}
    };

    public static string NumToWord(int num)
    {
      if (num > 15 && num < 20)
      {
        if (num - 10 == 8) return numWords[num - 10] + "een";
        return numWords[num - 10] + "teen";
      }
      else if (num >= 60 && num < 100)
      {
        if (num / 10 == 8) return numWords[num / 10] + "y";
        return numWords[num / 10] + "ty";
      }

      return numWords[num];
    }
  }
}