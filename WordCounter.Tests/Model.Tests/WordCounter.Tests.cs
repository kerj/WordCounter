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
  }
}
