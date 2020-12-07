using System;
using System.Collections.Generic;
using System.Text;

namespace DZ3
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string write)
        {
            Console.WriteLine(write); 
            
        }
    }
}
