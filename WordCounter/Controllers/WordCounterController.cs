
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/WordCounter")]
    public ActionResult Index()
    {
      List<WordToSearch> listOfSearches = WordToSearch.AllSearches;
      return View(listOfSearches);
    }

    [HttpGet("/WordCounter/New")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/WordCounter")]
    public ActionResult Create(string searchTerm, string phraseToSearch)
    {
      WordToSearch newWordToSearch = new WordToSearch(searchTerm, phraseToSearch);
      List<WordToSearch> listOfSearches = WordToSearch.AllSearches;
      return View("Index", listOfSearches);
    }

    [HttpPost("/WordCounter/{wordCounterId}")]
    public ActionResult Show(int id, string phraseToSearch)
    {
      WordToSearch phrase = WordToSearch.Find(id);
      int theCount = phrase.CountTheNumberOfTimesTermAppears();
      Dictionary<int, string> model = new Dictionary<int, string>();
      model.Add(theCount, phrase.PhraseToSearch);
      // model.Add("Phrase", phrase.PhraseToSearch);
      return View("Show", model);
    }
  }
}
