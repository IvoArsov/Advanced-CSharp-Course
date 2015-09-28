using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class LastDigitOfNumber
{

    private static string GetLastDigitAsWord(int inputNumber)
    {
        string outputDigit = String.Empty;
        switch (inputNumber)
        {
            case 1:
                outputDigit = "One";
                break;
            case 2:
                outputDigit = "Two";
                break;
            case 3:
                outputDigit = "Three";
                break;
            case 4:
                outputDigit = "Four";
                break;
            case 5:
                outputDigit = "Five";
                break;
            case 6:
                outputDigit = "Six";
                break;
            case 7:
                outputDigit = "Seven";
                break;
            case 8:
                outputDigit = "Eight";
                break;
            case 9:
                outputDigit = "Nine";
                break;
            case 0:
                outputDigit = "Zero";
                break;
            default:
                break;
        }
        return outputDigit;
    }



    static void Main(string[] args)
    {
        int inputNumber = int.Parse(Console.ReadLine());
        inputNumber = inputNumber % 10;
        string lastDigitAsWord = GetLastDigitAsWord(inputNumber);
        Console.WriteLine(lastDigitAsWord);
    }
}

