using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class CountSymbols
{
    private static void Main()
    {
        string words = Console.ReadLine();
        char[] arr = words.ToCharArray();
        Array.Sort(arr);
        int counter = 0;
        for (int index = 0; index < arr.Length - 1; index++)
        {
            counter++;
            if (arr[index] != arr[index + 1])
            {
                Console.WriteLine("{0}: {1} time/s", arr[index], counter);
                counter = 0;
            }

            if (index == arr.Length - 2)
            {
                Console.WriteLine("{0}: {1} time/s", arr[index + 1], ++counter);
            }
        }
    }
}

