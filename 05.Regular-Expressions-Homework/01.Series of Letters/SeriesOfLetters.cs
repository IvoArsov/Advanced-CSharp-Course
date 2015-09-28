using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class SeriesOfLetters
{
    static void Main()
    {
        string inputText = Console.ReadLine();
        string regexPattern = @"([a-z])\1+";
        Regex regex = new Regex(regexPattern);

        MatchCollection matches = Regex.Matches(inputText, regexPattern);
        for (int i = 0; i < matches.Count; i++)
        {
            string tempPattern = matches[i].ToString();
            string replace = tempPattern.First().ToString();
            Regex tempRegex = new Regex(tempPattern);
            inputText = tempRegex.Replace(inputText, replace);
        }
        Console.WriteLine(inputText);
    }
}

