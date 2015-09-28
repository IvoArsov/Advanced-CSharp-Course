using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StringLength
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        int inputStringRange = inputString.Length;
        if (inputStringRange < 20)
        {
            int lengthToTwenty = 20 - inputStringRange;
            string additionSymbols = new string('*', lengthToTwenty);
            Console.WriteLine("{0}", inputString + additionSymbols);
        }
        else
        {
            string exactTwenty = inputString.Substring(0, 20);
            Console.WriteLine(exactTwenty);
        }
    }
}

