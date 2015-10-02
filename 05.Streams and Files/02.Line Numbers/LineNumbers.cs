using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LineNumbers
{
    static void Main()
    {
        const string PATH_TEXT = "../../Example text.txt";
        const string PATH_OUTPUT = "../../Example result.txt";

        InsertLinesToResultFile(PATH_TEXT, PATH_OUTPUT);
        PrintResultContent(PATH_OUTPUT);
    }

    static void InsertLinesToResultFile(string pathText, string pathResult)
    {
        int lineCount = 1;

        using (StreamWriter result = new StreamWriter(pathResult))
        {
            using (StreamReader reader = new StreamReader(pathText))
            {
                while (!reader.EndOfStream) result.WriteLine("Line {0}: {1}", lineCount++, reader.ReadLine());
            }
        }
    }

    static void PrintResultContent(string path)
    {
        Console.WriteLine(" Result:\n");

        using (StreamReader reader = new StreamReader(path))
        {
            while (!reader.EndOfStream) Console.WriteLine(reader.ReadLine());
        }
        
        Console.WriteLine("\n End of file...\n");
    }
}

