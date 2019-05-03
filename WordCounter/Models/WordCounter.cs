using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
    public class WordToSearch
    {
      private string _searchTerm;
      private string _phraseToSearch;

      public WordToSearch(string searchTerm, string phraseToSearch)
      {
        _searchTerm = searchTerm;
        _phraseToSearch = phraseToSearch;
      }

      public string SearchTerm { get => _searchTerm; set => _searchTerm = value;}
      public string PhraseToSearch { get => _phraseToSearch; set => _phraseToSearch = value;}

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
