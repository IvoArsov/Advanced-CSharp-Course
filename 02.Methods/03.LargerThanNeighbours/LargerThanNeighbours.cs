using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


class LargerThanNeighbours
{
    private static bool CheckNeighbours(int[] nums, int position)
    {
        bool result;
        if (position == 0) result = nums[position] > nums[position + 1];
        else result = nums[position] > nums[position - 1] && nums[position] > nums[position + 1];
        return result;
    }


    static void Main(string[] args)
    {
        string[] inputStrings = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        int[] inputInts = new int[inputStrings.Length];
        for (int i = 0; i < inputStrings.Length; i++)
        {
            inputInts[i] = int.Parse(inputStrings[i]);
        }

        for (int i = 0; i < inputInts.Length; i++)
        {
            Console.WriteLine(CheckNeighbours(inputInts, i));
        }
    }
}



