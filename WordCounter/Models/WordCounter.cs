using System;
using System.Collections.Generic;


namespace WordCounter.Models
{
  public class WordToSearch
  {
    private string _searchTerm;
    private string _phraseToSearch;
    private static List<WordToSearch> _searches = new List<WordToSearch> {};
    private int _id;


    public WordToSearch(string searchTerm, string phraseToSearch)
    {
      _searchTerm = searchTerm;
      _phraseToSearch = phraseToSearch;
      _searches.Add(this);
      _id = _searches.Count;
    }

    public string SearchTerm { get => _searchTerm; set => _searchTerm = value;}
    public string PhraseToSearch { get => _phraseToSearch; set => _phraseToSearch = value;}
    public static List<WordToSearch> AllSearches { get => _searches; set => _searches = value;}
    public int Id { get => _id; set => _id = value;}

    public static WordToSearch Find(int searchId)
    {
      return _searches[searchId-1];
    }

    public string[] MakeSearchTermArray(string SearchTerm)
    {
      string[] searchArray = SearchTerm.ToLower().Split(' ');
      return searchArray;
    }

    public string[] MakeSentenceArray(string PhraseToSearch)
    {
      string[] stringArray = PhraseToSearch.ToLower().Split(' ');
      return stringArray;
    }

    public int DoesItContain(string[] searchArray, string[] stringArray)
    {
      int match = Array.IndexOf(stringArray, searchArray[0]);
      return match;
    }
    public int CountTheNumberOfTimesTermAppears()
    {
      string[] searchArray = MakeSearchTermArray(SearchTerm);
      string[] stringArray = MakeSentenceArray(PhraseToSearch);
      int count = 0;
      int matchStringInArray = DoesItContain(searchArray, stringArray);

      while(matchStringInArray >= 0)
      {
        stringArray[matchStringInArray] = "---";
        matchStringInArray = DoesItContain(searchArray, stringArray);
        count++;
      }
      return count;
    }
  }
}
