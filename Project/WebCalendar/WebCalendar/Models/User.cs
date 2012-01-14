using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace WebCalendar.Models
{
    public class User
    {
        public void CreateUser(string username, string password, string email)
        {
            using (WebCalendarEntities db = new WebCalendarEntities())
            {
                //User u = new User();

                
               
                //user.UserName = username;
                //user.Email = email;
                //user.Password = password;
                //user.PasswordSalt = "1234";


                //db.AddToUsers(user);
                db.SaveChanges();

              //  return GetUser(username);
            }
        }

    }
}