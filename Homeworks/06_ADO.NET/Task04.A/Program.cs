using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;

namespace ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {

            

            string queryString =
                 @"SELECT VALUE DISTINCT Customer
               FROM NorthwindEntities.Customers AS Customer
               INNER JOIN NorthwindEntities.Orders AS Order
               ON Customer.CustomerID=Order.CustomerID
               WHERE Year(Order.OrderDate) == 1997 &&
               Order.ShipCountry=='Canada'";


            
                var customerQuery = new ObjectQuery<Customer>(
queryString, DAO.db);


                foreach (var c in customerQuery)
                {
                    Console.WriteLine(c.ContactName);
                    Console.WriteLine(c.Address);

                }


        }
    }
}
