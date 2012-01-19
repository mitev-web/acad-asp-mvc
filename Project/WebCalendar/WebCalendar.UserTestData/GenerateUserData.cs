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

       public static void GenerateCategoriesForUser(User user, int numberCategories)
       {
           for (int i = 0; i < numberCategories; i++)
           {
               string categoryName = Faker.CompanyFaker.Name();
               string categoryDescription = Faker.TextFaker.Sentence();
               WebCalendar.DAL.CategoryDAL.CreateCategory(user, categoryName, categoryDescription);
           }

       }

       public static void GenerateMeetingsForUser(User user, int numberMeetings)
       {
           IEnumerable<Contact> contacts = ContactDAL.GetAllByUser(user);

           if (user.Contacts.Count > 3)
           {
               contacts = user.Contacts.Where(x => x.ID % 3 == 0);

           }
           else if (user.Contacts.Count > 0)
           {
               contacts.First();
           }
           else
           {
               //Console.WriteLine("The selected User don't have enough 

           }

           for (int i = 0; i < numberMeetings; i++)
           {
               DateTime date = Faker.DateTimeFaker.DateTime();
               string location = Faker.LocationFaker.Street();
               string description = Faker.StringFaker.Alpha(3) + Faker.TextFaker.Sentence();
               Random r = new Random();
               Category category = user.Categories.ToArray()[r.Next(0, user.Categories.Count - 1)];
               MeetingDAL.CreateMeeting(user,category, contacts, date, description, location);

           } 


       }
    }

}
