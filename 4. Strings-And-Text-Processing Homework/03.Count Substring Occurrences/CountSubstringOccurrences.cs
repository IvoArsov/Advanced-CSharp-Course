using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountSubstringOccurrences
{
    static void Main()
    {
        string text = Console.ReadLine();
        string stringToSearch = Console.ReadLine();
        Console.WriteLine(CountStringOccurrences(text,stringToSearch));
    }


    public static int CountStringOccurrences(string text, string stringToSearch)
    {
        int count = 0;
        int i = 0;
        while ((i = text.IndexOf(stringToSearch, i)) != -1)
        {
            i += stringToSearch.Length;
            count++;
        }
        return count;
    }
}

