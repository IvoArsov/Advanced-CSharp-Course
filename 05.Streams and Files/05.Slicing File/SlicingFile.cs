//don't work correctly for images
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SlicingFile
{
    private static void Slice(string sourceFile, string destinationDir, int numParts)
    {
        FileInfo fileInfo = new FileInfo(sourceFile);

        int size = (int)fileInfo.Length;
        int partSize = size / numParts;
        int lastPartSize = size - (numParts - 1) * partSize;

        string name = fileInfo.Name;
        string[] nameExtArr = name.Split('.');

        FileStream source = new FileStream(sourceFile, FileMode.Open);
        source.Seek(0, SeekOrigin.Current);
        for (int i = 0; i < numParts; i++)
        {
            int currentSize = (i == (numParts - 1)) ? lastPartSize : partSize;

            byte[] buffer = new byte[currentSize];
            source.Read(buffer, 0, currentSize);

            string currentFilePath = destinationDir + "Part-" + i + "." + nameExtArr[1];
            using (FileStream dest = new FileStream(currentFilePath, FileMode.Create))
                dest.Write(buffer, 0, currentSize);

        }
        source.Close();
    }

    private static void Assemble(List<string> files, string destinationDirectory)
    {
        string ext = files[0].Substring(files[0].LastIndexOf('.'));
        string destinationFile = destinationDirectory + "assembled" + ext;
        using (FileStream dest = new FileStream(destinationFile, FileMode.Append, FileAccess.Write))
        {
            foreach (string inFile in files)
            {
                using (FileStream source = new FileStream(inFile, FileMode.Open))
                {
                    byte[] buffer = new byte[4096];
                    int len;
                    while ((len = source.Read(buffer, 0, buffer.Length)) > 0)
                        dest.Write(buffer, 0, len);
                }
            }
        }
    }

    static void Main()
    {
        string sourceFile = "../../software-university-logo.png";
        string destinationDir = "../../parts/";
        int numParts = 5;
        Slice(sourceFile, destinationDir, numParts);
        List<string> files = new List<string> {  
                                "../../parts/Part-0.png",
                                "../../parts/Part-1.png",
                                "../../parts/Part-2.png",
                                "../../parts/Part-3.png",
                                "../../parts/Part-4.png",
                             };

        Assemble(files, destinationDir);
    }
}

