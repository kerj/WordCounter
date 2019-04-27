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

      public string[] MakeSearchTermArray(string searchSplit)
      {
        string[] searchArray = searchSplit.Split(' ');
        return searchArray;
      }

      public string[] MakeSentenceArray(string sentenceSplit)
      {
        string[] stringArray = sentenceSplit.Split(' ');
        return stringArray;
      }

      public int DoesItContain()
      {
        string[] searchArray = MakeSentenceArray(SearchTerm);
        string[] stringArray = MakeSearchTermArray(PhraseToSearch);
        int match = Array.IndexOf(stringArray, searchArray[0]);
        return match;
      }
    }
}
