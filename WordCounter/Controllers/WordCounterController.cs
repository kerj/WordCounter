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
  }
}
