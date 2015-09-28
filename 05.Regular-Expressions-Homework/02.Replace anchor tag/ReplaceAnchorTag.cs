using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class ReplaceAnchorTag
{
    static void Main()
    {
        string inputURL = Console.ReadLine();
        string regexPatern = @"<a(.*href=(.|\n)*?(?=>))>((.|\n)*?(?=<))<\/a>";
        Regex regex = new Regex(regexPatern);

        Match match = Regex.Match(inputURL, regexPatern);
        string replace = "[URL href=" + match.Groups[2] + "]" + match.Groups[3] + "[/URL]";
        string result = Regex.Replace(inputURL, regexPatern, replace);
        string quotes = @"""";
        result = Regex.Replace(result, quotes, "");
        Console.WriteLine(result);
    }
}

