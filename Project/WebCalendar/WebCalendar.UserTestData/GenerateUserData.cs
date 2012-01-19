using System;
using System.Collections.Generic;
using System.Linq;
using WebCalendar.DAL;

namespace WebCalendar.UserTestData
{
   class GenerateUserData
    {
       
       public static void GenerateContactsForUser(User user, int numberContacts)
       {

           for (int i = 0; i < numberContacts; i++)
           {
               
               string firstName = Faker.NameFaker.FirstName();
               string lastName = Faker.NameFaker.LastName();
               string email = Faker.StringFaker.Alpha(3)+Faker.InternetFaker.Email();
               string note = Faker.TextFaker.Sentence();
               string phone = Faker.PhoneFaker.Phone();
               string address = Faker.LocationFaker.StreetName() + " " + Faker.LocationFaker.StreetNumber();

               ContactDAL.CreateContact(user, firstName, lastName, email, note, phone, address);
           }
           
       }

       public static void GenerateMeetingCategoriesForUser(User user, int numberCategories)
       {


       }

       //public static void GenerateMeetingsForUser(User user, int numberMeetings)
       //{
       //    Random rand = new Random();
       //    IEnumerable<Contact> contacts = new IEnumerable<Contact>();

       //    if (user.Contacts.Count > 3)
       //    {
       //        contacts = user.Contacts.Where(x => x.ID % 3 == 0);

       //    }else if(user.Contacts.Count <= 3 && user.Contacts.Count > 0)
       //    {
       //        contacts.First();
       //    }

       //    for (int i = 0; i < numberMeetings; i++)
       //    {
       //        DateTime date = Faker.DateTimeFaker.DateTimeBetweenYears(2012, 2013);
       //        string location = Faker.LocationFaker.Street();
       //        string description = Faker.TextFaker.Sentence();
               
       //    } 


       //}
    }

}
