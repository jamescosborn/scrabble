using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class GameTest
  {
    [TestMethod]
    public void WordScore_WillGetScoreForSingleLetter_Int()
    {
      Assert.AreEqual(10, Game.WordScore("z"));
    }
    [TestMethod]
    public void WordScore_WillGetScoreForSingleCapitalLetter_Int()
    {
      Assert.AreEqual(10, Game.WordScore("Z"));
    }
    [TestMethod]
    public void WordScore_WillGetScoreForWord_Int()
    {
      Assert.AreEqual(8, Game.WordScore("hello"));
    }
    [TestMethod]
    public void WordScore_WillStopMultipleWords_Int()
    {
      Assert.AreEqual(10, Game.WordScore("ab cde"));
    }
    [TestMethod]
    public void WordScore_WillStopSpecialCharacters_Int()
    {
      Assert.AreEqual(10, Game.WordScore("ab-cde"));
    }
  }
}
