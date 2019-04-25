using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System;
using System.Collections.Generic;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTests
  {

    [TestMethod]
    public void CheckScore_Beforechanging_0()
    {
      //Arrange
      //Act

      //Arrange
      Assert.AreEqual(0, ScrabbleScore.ScoreIt(""));
    }
    [TestMethod]
    public void CheckLetter_AddsToArray_1()
    {
      Assert.AreEqual(1, ScrabbleScore.ScoreIt("a"));
    }
    [TestMethod]
    public void CheckLetter_AddsToArray_2()
    {
      Assert.AreEqual(3, ScrabbleScore.ScoreIt("go"));
    }
    [TestMethod]
    public void CheckMultiLetter_AddsToArray_4()
    {
      Assert.AreEqual(6, ScrabbleScore.ScoreIt("BoOt"));
    }
    [TestMethod]
    public void CheckLetter_AddsToArray_All()
    {
      Assert.AreEqual(87, ScrabbleScore.ScoreIt("abcdefghijkl mno pqrs tuv   wyxz") );
    }

    [TestMethod]
    public void CheckLetter_AddsToArray_nums()
    {
      Assert.AreEqual(8, ScrabbleScore.ScoreIt("h3y") );
    }
    [TestMethod]
    public void CheckLetter_AddsToArray_period()
    {
      Assert.AreEqual(8, ScrabbleScore.ScoreIt("h.y") );
    }
  }
}
