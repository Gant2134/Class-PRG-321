﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11_code
{
    public class ConsolePrinter : IPrinter
    {
       public void Print(string TheMessage)
       {
           Console.WriteLine(TheMessage);
       }
    }
}
