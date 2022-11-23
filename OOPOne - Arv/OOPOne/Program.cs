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

            Teacher mie = new Teacher("Dansk", "Mie", "Miesen", new DateTime(1971, 4, 12), 0);
            Teacher Freddy = new Teacher("Matematik", "Freddy", "Fazbear", new DateTime(1971, 4, 12), 0);
            Teacher Niels = new Teacher("Programmering", "Niels", "Olesen", new DateTime(1971, 4, 12), 0);

            Course Programmering = new Course("Programmering", Niels);
            Course Matematik = new Course("Matematik", Freddy);
            Course Dansk = new Course("Dansk", mie);

            //Console.WriteLine($"{Alex.Name} {Alex.LastName} {Alex.Age}");

            List<Enrollment> tilmeldingslist = new List<Enrollment>()
            {
            new (Alex, Programmering),
            new (Alex, Matematik),
            new (Alex, Dansk),

            new (Varian, Programmering),
            new (Varian, Matematik),
            new (Varian, Dansk),

            new (Anduin, Programmering),
            new (Anduin, Matematik),
            new (Anduin, Dansk)
            };

            /*
            tilmeldingslist.Add(new Enrollment(Alex, Programmering));
            tilmeldingslist.Add(new Enrollment(Alex, Matematik));
            tilmeldingslist.Add(new Enrollment(Alex, Dansk));
            */

            foreach (var items in tilmeldingslist)
            {
                Console.WriteLine($"Fornavn: {items.CourseInfo.TeacherInfo.FirstName} Efternavn: {items.CourseInfo.TeacherInfo.LastName} Fag: {items.CourseInfo.CourseName} Lærer: {items.CourseInfo.TeacherInfo.FirstName} {items.CourseInfo.TeacherInfo.LastName}");
            }
            Console.ReadLine();
        }
    }
}