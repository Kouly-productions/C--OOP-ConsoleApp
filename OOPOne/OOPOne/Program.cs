using OOPOne;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Alex = new Student(1, "Mike", "Scmith", new DateTime(1971, 2, 23), 0);
            Student Varian = new Student(2, "Varian", "Wrynn", new DateTime(1984, 1, 11), 0);
            Student Anduin = new Student(3, "Anduin", "Wrynn", new DateTime(1991, 7, 15), 0);

            Teacher mie = new Teacher();
            Teacher Freddy = new Teacher();
            Teacher Niels = new Teacher();

            Course Programmering = new Course("Programmering", Niels);
            Course Matematik = new Course("Matematik", Freddy);
            Course Dansk = new Course("Dansk", mie);

            //Console.WriteLine($"{Alex.Name} {Alex.LastName} {Alex.Age}");

            List<Enrollment> tilmeldingslist = new List<Enrollment>();
            Enrollment.Add enroll1 = new Enrollment(Alex, Programmering);
            Enrollment.Add enroll2 = new Enrollment(Alex, Matematik);
            Enrollment.Add enroll3 = new Enrollment(Alex, Dansk);

            foreach (var items in tilmeldingslist)
            {
                Console.WriteLine(items);
            }

        }
    }
}