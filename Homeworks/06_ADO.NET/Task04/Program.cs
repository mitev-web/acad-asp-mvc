using System;
using System.Data.Objects;
using System.Linq;

namespace ADO.NET
{
    class Program
    {

        static void Main()
        {


            //4.Implement previous by using native SQL 
            //query and executing it through the ObjectContext.

            string queryString =
            @"SELECT VALUE DISTINCT Customer
            FROM NorthwindEntities.Customers AS Customer
            INNER JOIN NorthwindEntities.Orders AS Order
            ON Customer.CustomerID=Order.CustomerID
            WHERE Year(Order.OrderDate) == 1997 &&
            Order.ShipCountry=='Canada'";

            var customerQuery = new ObjectQuery<Customer>(
            queryString, DAO.db);

            foreach (var q in customerQuery)
            {
                Console.WriteLine("The customer {0} have order made in 1997 and live in Canada.", q.ContactName);
            }
        }
    }
}
