using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Pesho = new Student("Pesho", "Peshev", 3.50);
            Student Ivan = new Student("Ivan", "Petrov", 2.00);
            Student Stoyan = new Student("Stoyan", "Mihailev", 5.50);
            Student Kocho = new Student("Kocho", "Balkanski", 6.00);
            Student Mimi = new Student("Pesho", "Peshev", 4.50);
            Student Petq = new Student("Petq", "Vetriloto", 2.00);
            Student Moni = new Student("Moni", "Bonboni", 5.75);
            Student Pipi = new Student("Pipi", "Krokodila", 3.00);
            Student Veso = new Student("Veso", "Kovalski", 5.75);
            Student Joro = new Student("Joro", "Shock-a", 6.00);

            List<Student> students = new List<Student> { Pesho, Ivan, Stoyan, Kocho, Mimi, Petq, Moni, Pipi, Veso, Joro };

            SortStudentsByGradeASC(students);

            Console.WriteLine("\n Sorted list by grade");
            foreach (Student student in students)
            {
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Grade);
            }

            Worker Pero = new Worker("Pero", "Perev", 400M, 8);
            Worker Bongo = new Worker("Bongo", "Petrov", 500M, 8);
            Worker Taz = new Worker("Stoyan", "Mihailev", 300M, 8);
            Worker Ibrahim = new Worker("Ibrahim", "Besniq", 200M, 12);
            Worker Stoil = new Worker("Stoil", "Popov", 999M, 8);
            Worker Kiril = new Worker("Kiril", "Kirilov", 1000M, 8);
            Worker Maria = new Worker("Maria", "Popova", 500M, 8);
            Worker Alex = new Worker("Alex", "Vulkova", 760M, 4);
            Worker Vassil = new Worker("Veso", "Kovalski", 2000M, 4);
            Worker Georgi = new Worker("Georgi", "Shock-a", 2200M, 6);

            List<Worker> workers = new List<Worker> { Pero, Bongo, Taz, Ibrahim, Stoil, Kiril, Maria, Alex, Vassil, Georgi };
            
            Console.WriteLine("\n Sorted list by money per hour");
            SortWorkersByMoneyPerHourDESC(workers);
            Console.WriteLine("The sorted workers list is:");
            foreach (Worker worker in workers)
            {
                Console.WriteLine("{0} {1} {2:0.00}", worker.FirstName, worker.LastName, worker.MoneyPerHour);
            }
        }

        public static void SortStudentsByGradeASC(List<Student> students)
        {
            for (int i = 0; i < students.Count - 1; i++)
            {
                Student tempStudent = new Student();

                if (i == (students.Count - 2) && students[students.Count - 1].Grade < students[students.Count - 2].Grade)
                {
                    tempStudent = students[students.Count - 1];
                    students[students.Count - 1] = students[students.Count - 2];
                    students[students.Count - 2] = tempStudent;
                    SortStudentsByGradeASC(students);

                }
                else if (students[i].Grade > students[i + 1].Grade)
                {
                    tempStudent = students[i];
                    students[i] = students[i + 1];
                    students[i + 1] = tempStudent;
                    SortStudentsByGradeASC(students);
                }
            }
        }




        public static void SortWorkersByMoneyPerHourDESC(List<Worker> workers)
        {

            for (int i = 0; i < workers.Count - 1; i++)
            {
                Worker tempWorker = new Worker();

                if (i == (workers.Count - 2) && workers[workers.Count - 1].MoneyPerHour > workers[workers.Count - 2].MoneyPerHour)
                {
                    tempWorker = workers[workers.Count - 1];
                    workers[workers.Count - 1] = workers[workers.Count - 2];
                    workers[workers.Count - 2] = tempWorker;
                    SortWorkersByMoneyPerHourDESC(workers);

                }else if (workers[i].MoneyPerHour < workers[i + 1].MoneyPerHour){
                    tempWorker = workers[i];
                    workers[i] = workers[i + 1];
                    workers[i + 1] = tempWorker;
                    SortWorkersByMoneyPerHourDESC(workers);
                }
            }

        }

    }
}
