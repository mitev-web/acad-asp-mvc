using System;
using System.Linq;
using System.Security.Cryptography;
using WebCalendar.DAL;

namespace WebCalendar.UserTestData
{
    class Program
    {
        static void Main(string[] args)
        {

            //User pesho = UserDAL.CreateUser("pesho", "pesho123", Faker.StringFaker.Alpha(3) + Faker.InternetFaker.Email(), "Petur", "Popov");

            //GenerateUserData.GenerateContactsForUser(pesho, 50);

            Console.WriteLine();

            Console.WriteLine(Faker.NameFaker.Name());
        }


    }
}
