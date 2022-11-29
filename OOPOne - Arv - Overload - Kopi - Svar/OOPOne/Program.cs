using OOPOne;
using System;
using System.Linq.Expressions;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher mie = new Teacher(CourseEnum.Computerteknologi, "Mie", "Miesen", new DateTime(1971, 4, 12), 0);
            Teacher Freddy = new Teacher(CourseEnum.OOP, "Freddy", "Fazbear", new DateTime(1971, 4, 12), 0);
            Teacher Niels = new Teacher(CourseEnum.Studieteknik, "Niels", "Olesen", new DateTime(1971, 4, 12), 0);

            Course Computerteknologi = new Course(CourseEnum.Computerteknologi, mie);
            Course Studieteknik = new Course(CourseEnum.Studieteknik, Freddy);
            Course OOP = new Course(CourseEnum.OOP, Niels);

            Enrollment x = new();

            Console.WriteLine("Write ID");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Write FirstName");
            string firstname = Console.ReadLine();

            Console.WriteLine("Write LastName");
            string lastname = Console.ReadLine();

            Console.WriteLine("Write your birth");
            DateTime birth = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write course");
            string course = Console.ReadLine();

            Console.Clear();

            Student s1 = new Student(id, firstname, lastname, birth, age);

            if(course == CourseEnum.Studieteknik.ToString())
            {
                x.Enrollments.Add(new Enrollment(s1, Studieteknik));
            }

            /*x.Enrollments = new List<Enrollment>()
            {
            new (Alex, Programmering),
            new (Varian, Matematik),
            new (Anduin, Programmering),
            new (Alex, Dansk),
            new (Anduin, Dansk),

            
            };*/
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