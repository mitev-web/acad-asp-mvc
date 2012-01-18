using System;
using System.Linq;

namespace WebCalendar.Models
{
    public class DAO
    {
        public static WebCalendarEntities db;

        static DAO()
        {
            db = new WebCalendarEntities();
        }


    }
}