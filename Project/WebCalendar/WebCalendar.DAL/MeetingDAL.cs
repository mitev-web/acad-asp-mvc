using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace WebCalendar.DAL
{
    public class MeetingData : DAO
    {
        public static IEnumerable<Meeting> GetAll(int userID)
        {
            IEnumerable<Meeting> meetings = from meeting in db.Meetings
                                            select meeting;

            return meetings;
        }

        public static IEnumerable<Meeting> GetAllByUserID(int userID)
        {
            IEnumerable<Meeting> meetings = from meeting in db.Meetings
                                            where meeting.UserID == userID
                                            select meeting;

            return meetings;
        }

        public static void CreateMeeting(User user, IEnumerable<Contact> contacts, DateTime date, string description, string location)
        {
            Meeting m = new Meeting();
            m.User = user;
            m.Date = date;
            m.Description = description;
            m.Location = location;
            //m.Contacts = <EntityCollection>contacts;

       
        }

        public static int CountAllByUserID(int userID)
        {
            int count = (from meeting in db.Meetings where meeting.UserID == userID select meeting).Count();

            return count;
        }

        public static Meeting GetByID(int meetingID)
        {
            Meeting meeting = (from m in db.Meetings where m.ID == meetingID select m).FirstOrDefault();

            return meeting;
        }

        public static void AddContactsToMeeting(Meeting meeting, IEnumerable<Contact> contacts)
        {
            foreach (Contact c in contacts)
            {
                meeting.Contacts.Add(c);
            }
            db.SaveChanges();
        }

        public static void AddContactToMeeting(Meeting meeting, Contact contact)
        {
            meeting.Contacts.Add(contact);
            db.SaveChanges();
        }

        public static void ChangeCategory(Meeting meeting, Category category)
        {
            meeting.Category = category;

            db.SaveChanges();
        }

        public static void RemoveByID(int meetingID)
        {
            object meetingForDeletion;

            EntityKey meetingKey = new EntityKey("WebCalendarEntities.Meetings", "ID", meetingID);

            if (db.TryGetObjectByKey(meetingKey, out meetingForDeletion))
            {
                try
                {
                    db.DeleteObject(meetingForDeletion);
                    db.SaveChanges();
                }
                catch (OptimisticConcurrencyException ex)
                {
                    throw new InvalidOperationException(string.Format(
                                                                      "The Meeting with an ID of '{0}' could not be deleted.\n" +
                                                                      "Make sure that any related objects are already deleted.\n",
                        meetingKey.EntityKeyValues[0].Value), ex);
                }
            }
            else
            {
                throw new InvalidOperationException(string.Format(
                                                                  "The Meeting with an ID of '{0}' could not be found.\n" +
                                                                  "Make sure that Product exists.\n",
                    meetingKey.EntityKeyValues[0].Value));
            }
        }
    }
}