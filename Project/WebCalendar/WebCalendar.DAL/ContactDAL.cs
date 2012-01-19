using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace WebCalendar.DAL
{
    public class ContactDAL : DAO
    {
        public static Contact GetByID(int contactID)
        {
            Contact contact = (from c in db.Contacts where c.ID == contactID select c).First();

            return contact;
        }

        public static IEnumerable<Contact> GetAll()
        {
            return db.Contacts;
        }

        public static IEnumerable<Contact> GetAllByUser(User u)
        {
            var e = db.Contacts.Where(x => x.User == u);
            return e;
        }

        public static IEnumerable<Contact> GetAllByUserID(int userID)
        {
            IEnumerable<Contact> contacts = from contact in db.Contacts
                                            where contact.UserID == userID
                                            select contact;

            return contacts;
        }

        public static int CountAllByUserID(int userID)
        {
            int count = (from con in db.Contacts where con.UserID == userID select con).Count();

            return count;
        }

        public static IEnumerable<Contact> GetAllByMeetingID(int meetingID)
        {
            IEnumerable<Contact> contacts = (from m in db.Meetings where m.ID == meetingID select m.Contacts).First();

            return contacts;
        }

        public static void CreateContact(User user, string firstName, string lastName, string email, string note, string phone, string address)
        {
            Contact c = new Contact()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Note = note,
                Phone = phone,
                Address = address,
                User = user
            };

            db.Contacts.AddObject(c);
            db.SaveChanges();
        }

        public static void RemoveByID(int contactID)
        {
            object contactForDeletion;

            EntityKey contactKey = new EntityKey("WebCalendarEntities.Contacts", "ID", contactID);

            if (db.TryGetObjectByKey(contactKey, out contactForDeletion))
            {
                try
                {
                    db.DeleteObject(contactForDeletion);
                    db.SaveChanges();
                }
                catch (OptimisticConcurrencyException ex)
                {
                    throw new InvalidOperationException(string.Format(
                                                                      "The Contact with an ID of '{0}' could not be deleted.\n" +
                                                                      "Make sure that any related objects are already deleted.\n",
                        contactKey.EntityKeyValues[0].Value), ex);
                }
            }
            else
            {
                throw new InvalidOperationException(string.Format(
                                                                  "The Contact with an ID of '{0}' could not be found.\n" +
                                                                  "Make sure that Contact exists.\n",
                    contactKey.EntityKeyValues[0].Value));
            }
        }
    }
}