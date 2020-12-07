using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DZ3
{
    public class FilePrinter : IPrinter
    {
        string fileName;

        public FilePrinter(string fileName)
        {
            this.fileName = fileName;
        }

        public void Print(string write)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine(write);
            }

        }
    }
}
