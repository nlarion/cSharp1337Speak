using System;
using System.Collections.Generic;

namespace L33tSpeak
{
  public class Translator
  {
    public static string Translate(string input)
    {
      char[] array = input.ToCharArray();
      for (int i = 0; i<array.Length; i++) {
        if (array[i] == Convert.ToChar('e'))
        {
          array[i] = Convert.ToChar("3");
        } else if (array[i] == Convert.ToChar("o")) {
          array[i] = Convert.ToChar("0");
        } else if (array[i] == Convert.ToChar("I")) {
          array[i] = Convert.ToChar("1");
        } else if (i>0) {
          if ((array[i] == Convert.ToChar("s") || array[i] == Convert.ToChar("S")) && array[i-1]!= Convert.ToChar(" ") && array[i-1]!= Convert.ToChar("'")) {
            array[i] = Convert.ToChar("z");
          }
        }
      }
      string result = string.Join("",array);
      return result;
    }
  }
}
