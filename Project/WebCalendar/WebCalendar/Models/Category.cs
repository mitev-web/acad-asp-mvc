using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCalendar.Models
{
    public class Category : DAO
    {

        public static IEnumerable<WebCalendar.Category> GetAll()
        {
            var e = from c in db.Categories
                    select c;

            return e;
        }




    }
}