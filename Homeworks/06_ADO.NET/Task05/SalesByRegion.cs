using System;
using System.Collections.Generic;
using System.Linq;
using Task01;

namespace ADO.NET
{
    class SalesByRegion
    {
        static void Main(string[] args)
        {
            //Write a method that finds all the sales by specified region and period
            //    (start / end dates).
            DateTime startDate = new DateTime(1996,1,1);
            DateTime endDate = new DateTime(1997, 1, 1);

           List<Order> orders =  DAO.GetSalesByRegionAndPeriod("RJ", startDate, endDate);

           foreach (var item in orders)
           {
               Console.WriteLine("Customer: {0}",item.Customer.ContactName);
               Console.WriteLine("Ship Date: {0}", item.ShippedDate);
           }
        }
    }
}
