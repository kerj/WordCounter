using System.Collections.Generic;

namespace WordCounter.Models
{
  public class CountDisplay
  {
    private string _phrase;
    private int _id;
    private static List<CountDisplay> _instances = new List<CountDisplay> {};

    public CountDisplay (string phrase)
    {
      _phrase = phrase;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string Phrase { get => _phrase; set => _phrase = value;}
    public static List<CountDisplay> Instances  { get => _instances; set => _instances = value;}
    public int Id { get => _id; set => _id = value;}

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static CountDisplay Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}
