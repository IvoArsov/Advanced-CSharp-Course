using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class ExtractEmails
{
    static void Main()
    {
        string inputText = Console.ReadLine();
        string regexPatern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
        Regex regex = new Regex(regexPatern);

        MatchCollection matches = regex.Matches(inputText);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Groups[0]);
        }
    }
}

