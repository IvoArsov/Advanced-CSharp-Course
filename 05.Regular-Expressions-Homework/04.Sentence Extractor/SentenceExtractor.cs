using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class SentenceExtractor
{
    static void Main()
    {
        string inputWord = Console.ReadLine();
        string inputText = Console.ReadLine();
        
        string pattern = string.Format(@"(?<=\s|^)[^!.?]*\b{0}\b[^!.?]*[!.?]", inputWord);
        MatchCollection matches = Regex.Matches(inputText, pattern, RegexOptions.IgnoreCase);
        foreach (Match sentence in matches)
        {
            Console.WriteLine(sentence.Groups[0]);
        }
    }
}
