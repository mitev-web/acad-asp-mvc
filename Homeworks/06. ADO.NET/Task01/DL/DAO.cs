using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using Task01;

namespace ADO.NET
{
    public class DAO
    {
        public static NorthwindEntities db;

       static DAO()
        {
            db = new NorthwindEntities();
        }



        public static void AddCustomer(string customerID, string contactName, string contactTitle, string companyName)
        {

            Customer c = new Customer()
            {
                CustomerID = customerID,
                ContactName = contactName,
                ContactTitle = contactTitle,
                CompanyName = companyName

            };
            db.Customers.AddObject(c);
            db.SaveChanges();

        }
        public static void DeleteCustomer(Customer c)
        {
            db.Customers.DeleteObject(c);
            db.SaveChanges();
        }

        public static void DeleteCustomerByID(string customerID)
        {
            Customer customer = db.Customers.FirstOrDefault(c => c.CustomerID == customerID);

            db.Customers.DeleteObject(customer);
            db.SaveChanges();
        }

        public static void UpdateCustomerContactName(Customer c, string contactName)
        {
            c.ContactName = contactName;
            db.SaveChanges();
        }

        public static List<Customer> GetAllCustomersByOrderDate(int orderYear, string country)
        {
            
            var customers = from o in db.Orders
                            join c in db.Customers on o.CustomerID equals c.CustomerID
                            where o.ShipCountry == country
                            where o.OrderDate.Value.Year == orderYear
                            select c;

            return customers.ToList<Customer>();

        }

        public static List<Order> GetSalesByRegionAndPeriod(string region, DateTime startDate, DateTime endDate)
        {
            var orders = from o in db.Orders
                         where o.ShipRegion == region
                         where o.ShippedDate > startDate
                         where o.ShippedDate < endDate
                         select o;


            return orders.ToList<Order>();
        }


        public static void AddOrderDetails(List<Product> products, Order o)
        {

            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    foreach (Product p in products)
                    {
                        Order_Detail od = new Order_Detail();
                        od.Order = o;
                        od.Product = p;
                        od.Quantity = 1;
                    }
                    db.SaveChanges();
                    ts.Complete();
                }
            }
            catch (TransactionAbortedException ex)
            {
                Console.WriteLine("TransactionAbortedException Message: {0}", ex.Message);

            }
            catch (ApplicationException ex)
            {
                Console.WriteLine("ApplicationException Message: {0}", ex.Message);
            }


                
            
        }


    }
}