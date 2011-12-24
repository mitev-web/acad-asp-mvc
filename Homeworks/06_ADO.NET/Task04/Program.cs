using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ADO.NET
{
    class Program
    {
     
            //Implement previous by using native SQL query and executing it through the 
            //ObjectContext.

                //SELECT * from Customers c
                //join orders o
                //On o.customerid = c.customerid
                //where YEAR(o.ShippedDate) = 1997
                //and o.ShipCountry = 'Canada'

        private const string CONNECTION_STRING = "Server=.\\SQLEXPRESS;" +
            " Database=Northwind; Integrated Security=true";
        private const string COMMAND_SELECT_CUSTOMERS = @"SELECT * from Customers c
                                                        join orders o
                                                        On o.customerid = c.customerid
                                                        where YEAR(o.ShippedDate) = 1997
                                                        and o.ShipCountry = 'Canada'";
        static void Main()
        {
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            con.Open();
            try
            {
                SqlCommand command = new SqlCommand(COMMAND_SELECT_CUSTOMERS, con);
                SqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        string customerName = (String)reader["ContactName"];
                        Console.WriteLine(customerName);
                    }
                }
            }
            finally
            {
                con.Close();
            }
  
        }
    }
}
