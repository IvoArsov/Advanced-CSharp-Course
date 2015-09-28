using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TextFilter
{
    static void Main()
    {
        string[] banList = Console.ReadLine().Split(new char[]{',',' '},StringSplitOptions.RemoveEmptyEntries);
        StringBuilder text = new StringBuilder(Console.ReadLine());
        string[] bannedAsAsterisks = new string[banList.Count()];


        for (int i = 0; i < banList.Count(); i++)
        {
            bannedAsAsterisks[i] = new string('*', banList[i].Length);
            text.Replace(banList[i], bannedAsAsterisks[i]);
        }
        Console.WriteLine(text);
    }
}

