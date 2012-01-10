using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Task01;


namespace ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            //Try to open two different data contexts and perform concurrent changes on 
            //the same records. What will happen at SaveChanges()? How to deal with it?

            NorthwindEntities db1 = new NorthwindEntities();
            NorthwindEntities db2 = new NorthwindEntities();
 

            Customer c1 = (from cs in db1.Customers
                         where cs.ContactName == "Maria Anders"
                         select cs).First();

            Customer c2 = (from cs in db2.Customers
                          where cs.ContactName == "Maria Anders"
                          select cs).First();


            c1.ContactName = "Maria Popova";

            c2.ContactName = "Maria Georgieva";

        }
    }
}
