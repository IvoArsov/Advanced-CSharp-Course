using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CollectTheCoins
{
    static int currRow = 0;
    static int currCol = 0;
    static int coins = 0;
    static int wallHits = 0;

    static void Main()
    {
        string[] field = new string[4];
        GetInputs(field);
        string moves = Console.ReadLine();
        DoMoves(moves, field);
        PrintResult();
    }

    static void DoMoves(string moves, string[] field)
    {
        CollectCoin(field); 
        foreach (char move in moves)
        {
            switch (move)
            {
                case '>':
                    PerformMove(field, currRow, currCol + 1);
                    break;
                case '<':
                    PerformMove(field, currRow, currCol - 1);
                    break;
                case '^':
                    PerformMove(field, currRow - 1, currCol);
                    break;
                case 'V':
                    PerformMove(field, currRow + 1, currCol);
                    break;
            }
        }
    }

    static void PerformMove(string[] field, int row, int col)
    {
        if (ValidMove(field, row, col))
        {
            currCol = col;
            currRow = row;
            CollectCoin(field);
        }
        else
        {
            wallHits++;
        }
    }

    static void PrintResult()
    {
        Console.WriteLine("Coins collected: {0}", coins);
        Console.WriteLine("Walls hit: {0}", wallHits);
    }

    static void CollectCoin(string[] field)
    {
        if (field[currRow][currCol] == '$')
        {
            coins++;
        }
    }

    static bool ValidMove(string[] field, int row, int col)
    {
        if (row >= 0 && row < field.Length)
        {
            if (col >= 0 && col < field[row].Length)
            {
                return true;
            }
        }
        return false;
    }

    static void GetInputs(string[] field)
    {
        for (int i = 0; i < field.Length; i++)
        {
            field[i] = Console.ReadLine();
        }
    }
}