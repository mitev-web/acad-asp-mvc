﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace WebCalendar.Models
{
    public class CategoryData : DAO
    {

        public static IEnumerable<Category> GetAll()
        {
            var e = from c in db.Categories
                    select c;

            return e;
        }



        public static void RemoveByID(int categoryID)
        {
            object categoryForDeletion;

            EntityKey categoryKey = new EntityKey("WebCalendarEntities.Categories", "ID", categoryID);

            if (db.TryGetObjectByKey(categoryKey, out categoryForDeletion))
            {
                try
                {
                    db.DeleteObject(categoryForDeletion);
                    db.SaveChanges();
                }
                catch (OptimisticConcurrencyException ex)
                {
                    throw new InvalidOperationException(string.Format(
                                                                      "The Category with an ID of '{0}' could not be deleted.\n" +
                                                                      "Make sure that any related objects are already deleted.\n",
                        categoryKey.EntityKeyValues[0].Value), ex);
                }
            }
            else
            {
                throw new InvalidOperationException(string.Format(
                                                                  "The Category with an ID of '{0}' could not be found.\n" +
                                                                  "Make sure that Category exists.\n",
                    categoryKey.EntityKeyValues[0].Value));
            }
        }


    }
}