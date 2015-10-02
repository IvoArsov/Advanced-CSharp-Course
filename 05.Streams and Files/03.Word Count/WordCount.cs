using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class WordCount
{
    static void Main()
    {
        using (var readerKeys = new StreamReader("../../words.txt"))
        {
            using (var readerText = new StreamReader("../../text.txt"))
            {
                using (var writerResult = new StreamWriter("../../result.txt"))
                {
                    var text = readerText.ReadToEnd().ToLower();
                    var result = new SortedDictionary<int, string>();
                    string word;
                    while ((word = readerKeys.ReadLine()) != null) 
                    {
                        var pattern = string.Format(@"\b{0}\b", word.ToLower());
                        var match = Regex.Matches(text, pattern);
                        result.Add(match.Count, word); 
                    }
                    foreach (var match in result.Reverse())
                    {
                        writerResult.WriteLine("{0} - {1}", match.Value, match.Key);
                    }
                }
            }
        }
    }
}

