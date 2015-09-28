using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CategorizeMinMaxAverage
{
    private static void Main()
    {
        string input = Console.ReadLine();
        string[] inputArray = input.Split();
        double[] numsArray = new double[input.Length];
        for (int i = 0; i < inputArray.Length; i++)
        {
            numsArray[i] = double.Parse(inputArray[i]);
        }

        List<double> doubles = new List<double>();
        List<double> ints = new List<double>();

        for (int i = 0; i < numsArray.Length; i++)
        {
            if (numsArray[i] % 1 != 0)
            {
                doubles.Add(numsArray[i]);
            }
            else if (numsArray[i] % 1 == 0)
            {
                ints.Add(numsArray[i]);
            }
        }

        Console.WriteLine();
        Console.WriteLine("[" + string.Join(", ", ints) + "] --> min:{0}, max:{1}, sum:{2}, avg:{3:f3}", ints.Min(), ints.Max(), ints.Sum(), ints.Average());
        Console.WriteLine();
        Console.WriteLine("[" + string.Join(", ", doubles) + "] --> min:{0}, max:{1}, sum:{2}, avg:{3:f3}", doubles.Min(), doubles.Max(), doubles.Sum(), doubles.Average());

    }
}

