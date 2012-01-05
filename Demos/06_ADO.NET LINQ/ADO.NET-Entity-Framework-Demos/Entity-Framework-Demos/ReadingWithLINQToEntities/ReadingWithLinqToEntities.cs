using System;
using System.Linq;
using UsingEntityFrameworkModel;

namespace ReadingWithLINQToEntities
{
    class ReadingWithLinqToEntities
    {
        static void Main()
        {
            NorthwindEntities northwindEntities = new NorthwindEntities();

            // Used to attach logs to the console
//            Logger.PrintQueries(northwindEntities);

            IQueryable<Customer> customers = from c in northwindEntities.Customers
                                             where c.City == "London"
                                             select c;

            Logger.PrintQueries(customers);

            Console.WriteLine("The query is still not generated and executed.");
            foreach (var item in customers)
            {
                Console.WriteLine("Company: {0}, Phone: {1}",
                                  item.CompanyName, item.Phone);
            }
        }
    }
}
