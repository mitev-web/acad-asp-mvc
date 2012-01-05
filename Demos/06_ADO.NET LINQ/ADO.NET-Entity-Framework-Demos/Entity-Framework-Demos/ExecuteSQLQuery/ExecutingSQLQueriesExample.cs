using System;
using System.Linq;
using UsingEntityFrameworkModel;
using System.Data.Objects;

namespace ExecuteSQLQuery
{
    class ExecutingSQLQueriesExample
    {
        static void Main()
        {
            using (NorthwindEntities northwindEntities = new NorthwindEntities())
            {
                string queryString =
                @"SELECT VALUE Customer FROM NorthwindEntities.Customers 
                AS Customer WHERE Customer.City=='London'";

                var customerQuery = new ObjectQuery<Customer>(queryString, northwindEntities);

                Logger.PrintQueries(customerQuery);
               
                foreach (Customer customer in customerQuery)
                {
                    Console.WriteLine("Company Name: {0}\n Contact Name: {1}\n City: {2}\n{3}",
                                      customer.CompanyName, customer.ContactName, customer.City, Logger.SeparatorLine);
                }
            }
        }
    }
}
