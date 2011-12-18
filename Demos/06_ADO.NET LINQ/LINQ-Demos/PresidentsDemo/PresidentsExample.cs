using System;
using System.Linq;

class PresidentsExample
{
    static void Main()
    {
        string[] presidents = { 
            "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", 
            "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield",
            "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson",
            "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", 
            "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft",
            "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"};
        string president = presidents.Where(p => p.StartsWith("Lin")).First();
        Console.WriteLine(presidents.Length);
        Console.WriteLine(president);
    }
}
