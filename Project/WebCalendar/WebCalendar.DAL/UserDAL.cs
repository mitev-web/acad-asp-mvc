using System;
using System.Linq;
using System.Security.Cryptography;

namespace WebCalendar.DAL
{
    public class UserDAL : DAO
    {
        public static User GetByID(int id)
        {
            var user = db.Users.Where(x => x.ID == id).FirstOrDefault();

            return (User)user;
        }

        public static User CreateUser(string username, string password, string email, string fName, string Lname)
        {
            User u = new User();
            u.UserName = username;
            u.Email = email;
            u.PasswordSalt = CreateSalt();
            u.Password = CreatePasswordHash(password, u.PasswordSalt);

            db.AddToUsers(u);
            db.SaveChanges();

            return u;
        }

        private static string CreateSalt()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[32];
            rng.GetBytes(buff);

            return Convert.ToBase64String(buff);
        }

        private static string CreatePasswordHash(string password, string salt)
        {
            string saltAndPwd = "mixing" + password + "with some" + salt;

            System.Security.Cryptography.SHA1 hash = System.Security.Cryptography.SHA1.Create();
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            byte[] combined = encoder.GetBytes(saltAndPwd);
            hash.ComputeHash(combined);
            string hashCode = Convert.ToBase64String(hash.Hash);

            return hashCode;
        }
    }
}