using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseNumber
{

    static string ReverseNum(string number)
    {
        char[] inputArray = number.ToCharArray();
        Array.Reverse(inputArray);
        return new string(inputArray);
    }

    static void Main(string[] args)
    {
        string number = Console.ReadLine();
        Console.WriteLine(ReverseNum(number));
    }
}

