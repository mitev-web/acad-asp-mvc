using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ADO.NET
{
    class Task02
    {
        static void Main(string[] args)
        {
            //Create a DAO class with static methods which provide functionality for
            //    inserting, modifying and deleting customers. Write a testing class.

            //Added in project 1

            
            if (DB.TestConnection())
            {
                Console.WriteLine("Test successfull");
            }
            else
            {
                Console.WriteLine("Error while testing");
            }

            

            
        }
    }
}
