using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

using WordCounter.Models;
using Microsoft.AspNetCore.Mvc;
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
      Assert.AreEqual(5, newSearch.MakeSentenceArray(newSearch.PhraseToSearch).Length);
    }
    [TestMethod]
    public void CheckValueInArray_CheckArrayToContainSearchTerm_True()
    {
      WordToSearch newSearch = new WordToSearch("cat", "the bat cat the hat");
      string[] searchArray = newSearch.MakeSearchTermArray(newSearch.SearchTerm);
      string[] stringArray = newSearch.MakeSentenceArray(newSearch.PhraseToSearch);
      Assert.AreEqual(2, newSearch.DoesItContain(searchArray, stringArray));
    }
    [TestMethod]
    public void CheckValueInArray_CountHowManySearchTermsAppear_3()
    {
      WordToSearch newSearch = new WordToSearch("cat", "cat cat it is a cat");
      Assert.AreEqual(3, newSearch.CountTheNumberOfTimesTermAppears());
    }

    [TestMethod]
    public void CheckValueInDictionary_KeyValuePresent_true()
    {
      WordToSearch newSearch = new WordToSearch("cat", "cat cat it is a cat");
      int key = newSearch.CountTheNumberOfTimesTermAppears();
      string value = newSearch.PhraseToSearch;
      newSearch.SetDictionary();
      Assert.AreEqual("cat cat it is a cat", newSearch.GetDictionary(key));
    }

    // [TestMethod]
    // public void CheckValueInArray_CountHowManySearchTermsAppear_3()
    // {
    //   WordToSearch newSearch = new WordToSearch("cat", "cat cat it is a cat");
    //   Assert.AreEqual(3, newSearch.CountTheNumberOfTimesTermAppears());
    // }

  }
}
