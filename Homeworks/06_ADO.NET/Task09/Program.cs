using System;
using System.Collections.Generic;
using System.Linq;
using Task01;

namespace ADO.NET
{
    class Task09
    {
        static void Main(string[] args)
        {
            //Create a method that places a new order in the Northwind database. 
            //    The order should contain several order items.
            //        Use transaction to ensure the data consistency.


            Product p1 = new Product();
            p1.ProductName = "Tesla";
            p1.UnitPrice = 20.20M;
            DAO.db.Products.AddObject(p1);


            Product p2 = new Product();
            p2.ProductName = "Kashon";
            p2.UnitPrice = 14.20M;
            DAO.db.Products.AddObject(p2);

            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p2);

            Order order = new Order();
            order.ShipCountry = "Bulgaria";
            order.CustomerID = "ALFKI";

            DAO.db.Orders.AddObject(order);

            DAO.db.SaveChanges();


            DAO.AddOrderDetails(products, order);
        }
    }
}
