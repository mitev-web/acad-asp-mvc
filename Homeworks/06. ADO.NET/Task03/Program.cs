using System;
using System.Collections.Generic;
using System.Linq;
using Task01;


namespace ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that finds all customers who have orders made in 1997 and 
            //    shipped to Canada.

            List<Customer> customers = DAO.GetAllCustomersByOrderDate(1997, "Canada");

            foreach (var c in customers) Console.WriteLine(c.ContactName);

        }
    }
}
