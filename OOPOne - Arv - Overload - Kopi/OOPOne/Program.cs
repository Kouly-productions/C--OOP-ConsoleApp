using OOPOne;
using System;
using System.Linq.Expressions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Alex = new Student(1, "Mike", "Scmith", new DateTime(1971, 2, 23), 0);
            Student Varian = new Student(2, "Varian", "Wrynn", new DateTime(1984, 1, 11), 0);
            Student Anduin = new Student(3, "Anduin", "Wrynn", new DateTime(1991, 7, 15), 0);

            Teacher mie = new Teacher(CourseEnum.Computerteknologi, "Mie", "Miesen", new DateTime(1971, 4, 12), 0);
            Teacher Freddy = new Teacher(CourseEnum.OOP, "Freddy", "Fazbear", new DateTime(1971, 4, 12), 0);
            Teacher Niels = new Teacher(CourseEnum.Studieteknik, "Niels", "Olesen", new DateTime(1971, 4, 12), 0);

            Course Programmering = new Course(CourseEnum.Computerteknologi, Niels);
            Course Matematik = new Course(CourseEnum.Studieteknik, Freddy);
            Course Dansk = new Course(CourseEnum.OOP, mie);

            Enrollment x = new();
            x.Enrollments = new List<Enrollment>()
            {
            new (Alex, Programmering),
            new (Varian, Matematik),
            new (Anduin, Programmering),
            new (Alex, Dansk),
            new (Anduin, Dansk),

            new (Alex, Programmering),
            new (Alex, Programmering),
            new (Alex, Programmering),
            new (Alex, Programmering),
            new (Alex, Programmering),
            new (Alex, Programmering),
            };
            try
            {
                if (x.Enrollments.Count < 8)
                {
                    throw new Exception("There is too few students");
                }
                else if (x.Enrollments.Count > 16)
                {
                    throw new Exception("There are too many students");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            x.Enrollments.Sort();
            /*
            tilmeldingslist.Add(new Enrollment(Alex, Programmering));
            tilmeldingslist.Add(new Enrollment(Alex, Matematik));
            tilmeldingslist.Add(new Enrollment(Alex, Dansk));
            */

            foreach (var item in x.Enrollments)
            {
                Console.WriteLine($"{ item.StudentInfo.FirstName} {item.StudentInfo.LastName}");
            }
            /*
            Alex.GetAge();
            mie.GetAge();
            mie.GetDepartment();

            Alex.GetAllCourse(x);
            mie.GetAllCourse(x);
            */
        }
    }
}