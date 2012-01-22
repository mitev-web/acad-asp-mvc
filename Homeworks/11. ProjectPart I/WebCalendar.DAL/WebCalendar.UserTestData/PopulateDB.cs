using System;
using System.Linq;
using WebCalendar.DAL;

namespace WebCalendar.UserTestData
{
    class PopulateDB
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Generate Test User data for a number of Users
            /// by default for every user are added:
            ///  30 Contacts and 15 Meetings with Categories for each Contact
            /// </summary>
       
            GenerateTestData.GenerateUserData(20);
        }
    }
}