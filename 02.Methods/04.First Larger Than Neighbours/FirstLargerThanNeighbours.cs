using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static int[] arr;

    static bool GetFirstLarger(int index)
    {
        bool firstLarger;
        if (index == 0)
        {
            firstLarger = arr[index] > arr[index + 1];
        }
        else if (index == arr.Length - 1)
        {
            firstLarger = arr[index] > arr[index - 1];
        }
        else
        {
            firstLarger = arr[index] > arr[index - 1] && arr[index] > arr[index + 1];
        }
        return firstLarger;
    }
    static void Main(string[] args)
    {
        string inputStringArray = Console.ReadLine();
        arr = inputStringArray.Split().Select(int.Parse).ToArray();
        bool isGreater = false;

        for (int i = 0; i < arr.Length; i++)
        {
            if (GetFirstLarger(i))
            {
                Console.WriteLine(i);
                isGreater = true;
                break;
            }
        }
        if (!isGreater)
        {
            Console.WriteLine("-1");
        }
    }
}
