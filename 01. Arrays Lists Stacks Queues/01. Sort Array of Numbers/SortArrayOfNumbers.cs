using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


class SortArrayOfNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputArr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[inputArr.Length];
        for (int i = 0; i < inputArr.Length; i++)
        {
            numbers[i] = int.Parse(inputArr[i]);
        }
        Array.Sort(numbers);
        Console.WriteLine(string.Join(" ", numbers));
    }
}

