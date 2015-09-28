using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Enter a word:");
        string inputData = Console.ReadLine();
        inputData.Reverse();
        Console.WriteLine("Reversed word:{0}",inputData);
    }
}
