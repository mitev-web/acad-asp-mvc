using System;
using System.Linq;

class StandardQueryOperators
{
    static void Main()
    {
        string[] currentVideoGames = {
            "Morrowind", "BioShock",
            "Half Life 2: Episode 1", "The Darkness",
            "Daxter", "System Shock 2"};

        // Build a query expression using extension methods
        // granted to the Array via the Enumerable type.
        var subset = from g in currentVideoGames
                     where g.Length > 6
                     orderby g
                     select g;
        //currentVideoGames.Where(game => game.Length > 6)
        //  .OrderBy(game => game).Select(game => game);
        
        // Print out the results
        foreach (var game in subset)
        {
            Console.WriteLine("Item: {0}", game);
        }
        Console.WriteLine();
    }
}
