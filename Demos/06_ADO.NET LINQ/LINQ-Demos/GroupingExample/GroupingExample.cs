using System;
using System.Linq;

class GroupingExample
{
    static void Main()
    {
        var people = new[] { 
            new { Name = "Kiki", Town = "Plovdiv" },
            new { Name = "Pepi", Town = "Sofia" },
            new { Name = "Koko", Town = "Sofia" },
            new { Name = "Mimi", Town = "Plovdiv" }
        };
        var peopleByTowns = from p in people
                            group p by p.Town;
        foreach (var town in peopleByTowns)
        {
            Console.Write("Town {0}: ", town.Key);
            foreach (var person in town)
                Console.Write("{0} ", person.Name);
            Console.WriteLine();
        }
    }
}
