using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
    public class WordToSearch
    {
      private string SearchTerm;
      private string PhraseToSearch;

      public WordToSearch(string searchTerm, string phraseToSearch)
      {
        SearchTerm = searchTerm;
        PhraseToSearch = phraseToSearch;
      }

      public string GetSearchTerm()
      {
        return SearchTerm;
      }

      public string GetPhraseToSearch()
      {
        return PhraseToSearch;
      }

      public string[] MakeSearchTermArray(string SearchTerm)
      {
        string[] searchArray = SearchTerm.Split(' ');
        return searchArray;
      }

      public string[] MakeSentenceArray(string PhraseToSearch)
      {
        string[] stringArray = PhraseToSearch.Split(' ');
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
