using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_02
{
    public class Worker : Human
    {
        private decimal weekSalary;

        public decimal WeekSalary
        {
            get { return weekSalary; }
            set { weekSalary = value; }
        }

        public decimal MoneyPerHour
        {
            get { return WeekSalary / 5 / (decimal) workHoursPerDay; }
        }


        private byte workHoursPerDay;

        public byte WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set { workHoursPerDay = value; }
        }


        public Worker(string firstName, string lastName, decimal weekSalary, byte workHoursPerDay)
        {
            FirstName = firstName;
            LastName = lastName;
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
        }


        public Worker()
        {

        }


    }
}
