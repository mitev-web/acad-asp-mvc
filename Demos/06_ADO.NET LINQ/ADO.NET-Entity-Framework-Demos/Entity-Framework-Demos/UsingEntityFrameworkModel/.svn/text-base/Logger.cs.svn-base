using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Objects.DataClasses;
using System.Data.Objects;

namespace UsingEntityFrameworkModel
{
    public class Logger
    {
        public static string SeparatorLine { get; private set; }
    
        static Logger()
        {
            SeparatorLine = new string('-', 50);
        }

        public static void PrintQueries(Object query)
        {
            Console.WriteLine(SeparatorLine);
            Console.WriteLine((query as ObjectQuery).ToTraceString());
            Console.WriteLine(SeparatorLine);
        }
    }
}
