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
      WordToSearch("cat", "the cat in the hat");
      Assert.AreEqual("cat", MakeSentenceArray());
    }
  }
}
