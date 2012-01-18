using System;
using System.Linq;
using Task01;

namespace ADO.NET
{
    public class DB
    {
       public static bool TestConnection()
        {
            try
            {
                DAO.AddCustomer("24234", "Pero Perev", "Manager", "Coca Cola ltd");

                Customer customer = (from c in DAO.db.Customers
                                     where c.ContactName == "Pero Perev"
                                     select c).First();

                DAO.UpdateCustomerContactName(customer, "Pero Halbata");
                DAO.DeleteCustomer(customer);
                return true;

            }catch(Exception e){

                Console.WriteLine(e.Message);

                return false;
            }

        }
    }
}
