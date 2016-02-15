using Xunit;
using System;
using System.Collections.Generic;

namespace L33tSpeak
{
  // public class TranslatorTest : IDisposable
  public class TranslatorTest
  {
    [Fact]
    public void Test1LetterEReplaceWith3()
    {
      //Arrange
      string input = "heel";
      string returnString = "h33l";
      //Act
      string newTranslator =  Translator.Translate(input);
      //Assert
      Assert.Equal(newTranslator, returnString);
    }
    [Fact]
    public void Test1LetterOReplaceWith0()
    {
      //Arrange
      string input = "hello";
      string returnString = "h3ll0";
      //Act
      string newTranslator =  Translator.Translate(input);
      //Assert
      Assert.Equal(newTranslator, returnString);
    }
    [Fact]
    public void Test1LetterLReplaceWith1()
    {
      //Arrange
      string input = "Iota";
      string returnString = "10ta";
      //Act
      string newTranslator =  Translator.Translate(input);
      //Assert
      Assert.Equal(newTranslator, returnString);
    }
    [Fact]
    public void Test1LetterSReplaceWithZ()
    {
      //Arrange
      string input = "Snakes";
      string returnString = "Snak3z";
      //Act
      string newTranslator =  Translator.Translate(input);
      //Assert
      Assert.Equal(newTranslator, returnString);
    }
    [Fact]
    public void TestExampleSample()
    {
      //Arrange
      string input = "Don't you love these 'String' exercises? I do!";
      string returnString = "D0n't y0u l0v3 th3z3 'String' 3x3rciz3z? 1 d0!";
      //Act
      string newTranslator =  Translator.Translate(input);
      //Assert
      Assert.Equal(newTranslator, returnString);
    }
  }
}
