using System;
using System.IO;
using System.Linq;
using Task01;


namespace Task06
{
    class NorthWindTwin
    {
        static void Main(string[] args)
        {
            //Create a database called NorthwindTwin with the same structure as Northwind 
            //using the features from ObjectContext. Find for the API for schema generation 
            //    in MSDN or in Google.
          
            NorthwindEntities context = new NorthwindEntities();
            string DBscript;

            DBscript = context.CreateDatabaseScript();
            //DBscript.Replace("Northwind", "NorthwindTwin");
            DBscript = "CREATE DATABASE [NorthwindTwin] \ngo  \nuse [NorthwindTwin] \n" + DBscript;

            //Create NEW file
            StreamWriter northwindTwinFile = new StreamWriter("CreateNorthwindTwinDB2.sql");

            //Save the script from NorthwindDB in the created file(saveTheFile)
            using (northwindTwinFile)
            {
                northwindTwinFile.WriteLine(DBscript);
            }
            Console.WriteLine(DBscript);
        }
    }
}
