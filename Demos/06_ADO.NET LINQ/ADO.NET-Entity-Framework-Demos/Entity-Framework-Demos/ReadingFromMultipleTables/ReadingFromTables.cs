using System;
using System.Linq;
using UsingEntityFrameworkModel;

namespace ReadingFromMultipleTables
{
    class ReadingFromTables
    {
        static void Main()
        {
            NorthwindEntities northwindEntities = new NorthwindEntities();

            var orders =
            from o in northwindEntities.Orders
            where o.Customer.Country == "UK"
            select o;
            Logger.PrintQueries(orders);

            foreach (var item in orders)
            {
                Console.WriteLine("Order Dates To UK: {0}",
                                  item.OrderDate.Value.ToShortDateString());
            }
        }
    }
}
