using System;
using System.Collections.Generic;
using System.Linq;

class LongestIncreasingSequence
{
    static void Main()
    {
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
        Dictionary<int, List<int>> sorted = new Dictionary<int, List<int>>();
        sorted[0] = new List<int>();
        sorted[0].Add(numbers[0]);
        for (int i = 1, index = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < numbers[i - 1] || numbers[i] == numbers[i - 1])
            {
                index++;
            }
            if (!sorted.Keys.Contains(index))
            {
                sorted[index] = new List<int>();
            }
            sorted[index].Add(numbers[i]);
        }
        foreach (var key in sorted.Keys)
        {
            Console.WriteLine(string.Join(" ", sorted[key]));
        }
        var longest = sorted.OrderByDescending(a => a.Value.Count).First().Value;
        Console.WriteLine("Longest: {0}", string.Join(" ", longest));
    }
}

