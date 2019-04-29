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
      WordToSearch newSearch = new WordToSearch("cat", "the cat in the hat");
      Assert.AreEqual(typeof(WordToSearch), newSearch.GetType());
    }
    [TestMethod]
    public void CheckValueInArray_InputArrayLength_5()
    {
      WordToSearch newSearch = new WordToSearch("cat", "the cat in the hat");
      Assert.AreEqual(5, newSearch.MakeSentenceArray(newSearch.GetPhraseToSearch()).Length);
    }
    [TestMethod]
    public void CheckValueInArray_CheckArrayToContainSearchTerm_True()
    {
      WordToSearch newSearch = new WordToSearch("cat", "the bat cat the hat");
      string[] searchArray = newSearch.MakeSearchTermArray(newSearch.GetSearchTerm());
      string[] stringArray = newSearch.MakeSentenceArray(newSearch.GetPhraseToSearch());
      Assert.AreEqual(2, newSearch.DoesItContain(searchArray, stringArray));
    }
    [TestMethod]
    public void CheckValueInArray_CountHowManySearchTermsAppear_3()
    {
      WordToSearch newSearch = new WordToSearch("cat", "cat cat it is a cat");
      Assert.AreEqual(3, newSearch.CountTheNumberOfTimesTermAppears());
    }
  }
}
