using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class OddLines
{
    private static void Main()
    {
        StreamReader reader = new StreamReader("../../Example text.txt");
        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                line = reader.ReadLine();
                if (lineNumber++ % 2 != 0 )
                {
                    Console.WriteLine(line);
                }
            }
            
        }
    }
}

