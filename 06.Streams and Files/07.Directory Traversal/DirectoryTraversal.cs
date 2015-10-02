using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class DirectoryTraversal
{
    protected class FileProperties
    {
        public string name { get; set; }
        public string extension { get; set; }
        public double length { get; set; }
    }

    protected static List<FileProperties> listFileProp = new List<FileProperties>();

    private static void Main()
    {
        string myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        DirectoryInfo dirInfo = new DirectoryInfo(myDocuments);
        FileInfo[] filesInfo = dirInfo.GetFiles();

        foreach (FileInfo fInfo in filesInfo)
        {
            FileProperties fProp = new FileProperties
            {
                name = fInfo.Name,
                extension = fInfo.Extension,
                length = fInfo.Length/1024.0
            };
            listFileProp.Add(fProp);
        }
        var queryFiles =
            from fProp in listFileProp
            orderby fProp.length
            group fProp by fProp.extension
            into extensionGroup
            orderby extensionGroup.Count() descending, extensionGroup.Key
            select extensionGroup;

        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        StreamWriter sw = new StreamWriter(desktop + "/report.txt");
        foreach (var extGroup in queryFiles)
        {
            sw.WriteLine(extGroup.Key);
            foreach (var fProp in extGroup)
                sw.WriteLine("--{0} - {1:f2}kb", fProp.name, fProp.length);
        }
        sw.Close();
    }

}