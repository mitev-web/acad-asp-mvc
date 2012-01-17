using System;
using System.Collections.Generic;
using System.Linq;

namespace WebCalendar.Models
{
    public class Contact : DAO
    {

        public static IEnumerable<WebCalendar.Contact> GetAllByUserID(int userID)
        {
            var c = from con in db.Contacts
                    where con.UserID == userID
                    select con;

            return c;

        }


        public static int CountAllByUserID(int userID)
        {
            int count = (from con in db.Contacts
                    where con.UserID == userID
                    select con).Count();

            return count;

        }


    }
}