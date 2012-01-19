using System;
using System.Linq;
using WebCalendar.DAL;

namespace WebCalendar.UserTestData
{
    class Program
    {
        static void Main(string[] args)
        {

            User pesho = UserDAL.CreateUser("sdafs", "pesho123", Faker.StringFaker.Alpha(3) + Faker.InternetFaker.Email(), Faker.NameFaker.FirstName(), Faker.NameFaker.LastName());

            //User pesho = UserDAL.GetByUserName("mirkata");

            GenerateUserData.GenerateContactsForUser(pesho, 20);
            GenerateUserData.GenerateCategoriesForUser(pesho, 3);
            GenerateUserData.GenerateMeetingsForUser(pesho, 2);

        }


    }
}
