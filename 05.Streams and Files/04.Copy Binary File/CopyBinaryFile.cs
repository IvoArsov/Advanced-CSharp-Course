using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class CopyBinaryFile
{
    static void Main()
    {
        using (FileStream text = new FileStream("../../software-university-logo.png",FileMode.Open))
        {
            using (FileStream copiedText = new FileStream("../../software-university-logo-binary.txt",FileMode.Create))
            {
                byte[] buffer = new byte[4096];
                int len;
                while ((len = text.Read(buffer, 0, buffer.Length)) > 0)
                {
                    copiedText.Write(buffer, 0, len);
                }
            }
        }
    }
}

