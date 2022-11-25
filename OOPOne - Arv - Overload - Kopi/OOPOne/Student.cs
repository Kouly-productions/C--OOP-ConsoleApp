using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OOPOne
{
    public class Student : PersonalInformation
    {
		public Student(int studentId, string firstName, string lastName, DateTime dateoftime, int age) : base(firstName, lastName, age)
		{
            StudentId = studentId;
        }


		public int StudentId
		{
			get;
			set;
		}

		public override List<string> GetAllCourse(Enrollment en)
		{
            List<string> courses = new List<string>();
			foreach (var item in en.Enrollments)
			{
				if (item.StudentInfo.FirstName == FirstName && item.StudentInfo.LastName == LastName)
				{
					courses.Add($"{item.StudentInfo.FirstName} {item.CourseInfo.CourseName}");
				};
			}
            return courses;
		}

        public override void GetAllCourse(List<Enrollment> en)
        {
            //en.Sort();
            foreach (var enrollment in en)
            {
                foreach (var item in enrollment.Enrollments)
                {
                    if (item.StudentInfo.FirstName == FirstName && item.StudentInfo.LastName == LastName)
                    {
                        Console.WriteLine($"{item.StudentInfo.FirstName} {item.CourseInfo.CourseName}");
                    };
                }
            }
        }
        /*
        public override void WriteAllNames(Enrollment en)
        {
			Console.WriteLine("Hej Niels");
        }
		*/
    }
}
