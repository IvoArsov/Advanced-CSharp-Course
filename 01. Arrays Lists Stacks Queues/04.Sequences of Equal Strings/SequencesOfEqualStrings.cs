using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SequencesOfEqualStrings
{
    private static void Main()
    {
        string input = Console.ReadLine();
        string[] words = input.Split();
        for (int i = 0; i < words.Length; i++)
        {
            Console.Write(words[i] + " ");
            if (!words[i].Equals(words[i+1]))
            {
                Console.WriteLine();
            }
        }
        Console.Write(words[words.Length-1]);
        Console.WriteLine();
    }
}

