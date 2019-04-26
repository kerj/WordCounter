using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTesting
  {
    [TestMethod]
    public void CheckValueInArray_WordAddedToArray_True()
    {
      string[] searchTerm = { "" };
      searchTerm[0] = "cat";
      Assert.AreEqual("cat", searchTerm[0]);
    }
    [TestMethod]
    public void CheckValueInArray_PhraseArrayCreated_True()
    {
      string[] searchTerm = { "" };
      searchTerm[0] = "cat";
      string phraseToSearch =  "";
      phraseToSearch = "the cat in the hat";
      phraseToSearch.ToLower();
      string[] phraseArray = phraseToSearch.Split(' ');
      Assert.AreEqual(searchTerm[0], phraseArray[1]);
    }
  }
}
