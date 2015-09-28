using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BiggerNumber
{
    private static int GetMax(int firstNum, int secondNum)
    {
        if (firstNum > secondNum)
        {
            return firstNum;
        }
        else if (firstNum < secondNum)
        {
            return secondNum;
        }
        return 0;
    }

    static void Main(string[] args)
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        int sum = GetMax(firstNum, secondNum);
        Console.WriteLine(sum);
    }
}

