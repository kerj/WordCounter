using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class CountDisplayController : Controller
  {
    [HttpGet("/WordCounter/{wordCounterId}/CountDisplay/new")]
    public ActionResult New(int wordCounterId)
    {
       WordToSearch phrase = WordToSearch.Find(wordCounterId);
       return View(phrase);
    }

    [HttpGet("/WordCounter/{wordCounterId}/CountDisplay{CountDisplayId}")]
    public ActionResult Show(int wordToSearchId, int countDisplayId)
    {
      CountDisplay countDisplay = CountDisplay.Find(countDisplayId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      WordToSearch wordToSearch = WordToSearch.Find(wordToSearchId);
      model.Add("countDisplay", countDisplay);
      model.Add("wordToSearch", wordToSearch);
      return View(model);
    }

    [HttpPost("/countDisplay/delete")]
    public ActionResult DeleteAll()
    {
      CountDisplay.ClearAll();
      return View();
    }

  }
}
