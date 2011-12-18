using System;
using System.Collections.Generic;
using System.Linq;

class NestedQuery
{
    private class Person
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int RoleID { get; set; }

        public override string ToString()
        {
            return String.Format(
                "ID={0}, Name={1}, RoleID={2}",
                ID, Name, RoleID);  
        }
    }

    private class Role
    {
        public int ID { get; set; }

        public string RoleName { get; set; }
    }

    static void Main()
    {
        List<Person> people = new List<Person>{
            new Person{ ID = 1, RoleID = 1, Name = "Peter"},
            new Person{ ID = 1, RoleID = 2, Name = "Peter"},
            new Person{ ID = 2, RoleID = 2, Name = "Steve"},
            new Person{ ID = 3, RoleID = 2, Name = "Susan"},
            new Person{ ID = 4, RoleID = 1, Name = "Bob"}
        };
        List<Role> roles = new List<Role>{
            new Role{ ID = 1, RoleName = "Manager" },
            new Role{ ID = 2, RoleName = "Developer" }
        };
        var query = people
        .Where(p => p.ID == 1)
        .SelectMany(p => roles
                    .Where(r => r.ID == p.RoleID)
                    .Select(r => new { p.Name, r.RoleName }));

        foreach (var result in query)
        {
            Console.WriteLine(result);
        }
    }
}
