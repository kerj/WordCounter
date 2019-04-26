using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
    class WordToSearch
    {
      public string SearchTerm;
      public string PhraseToSearch;

      public WordToSearch(string searchTerm,string phraseToSearch)
      {
        SearchTerm = searchTerm;
        PhraseToSearch = phraseToSearch;
      }

      public string[] MakeSentenceArray()
      {
        string[] stringArray = PhraseToSearch.Split(' ');
        return stringArray;
      }
    }
}
