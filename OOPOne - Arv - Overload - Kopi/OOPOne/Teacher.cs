using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPOne
{
    public class Teacher : PersonalInformation
    {
		private string _Detpartment;

        public Teacher(CourseEnum department, string firstName, string lastName, DateTime dateoftime, int age) : base(firstName, lastName, age)
        {
            Department = department;
            FirstName = firstName;
            LastName = lastName;
            DateOfTime = dateoftime;
            Age = age;
        }

		public CourseEnum Department
		{
            get;
            set;
		}
        public void GetDepartment()
        {
            Console.WriteLine(Department);
        }

        public override List<string> GetAllCourse(Enrollment en)
        {
            List<string> courses = new List<string>();
            foreach (var item in en.Enrollments)
            {
                if (item.CourseInfo.TeacherInfo.FirstName == FirstName && item.CourseInfo.TeacherInfo.LastName == LastName)
                {
                    courses.Add($"{item.StudentInfo.FirstName} {item.CourseInfo.CourseName}");
                }
            }
            return courses;
        }

        public override void GetAllCourse(List<Enrollment> en)
        {
            foreach (var enrollment in en)
            {
                foreach (var item in enrollment.Enrollments)
                {
                    if (item.CourseInfo.TeacherInfo.FirstName == FirstName && item.CourseInfo.TeacherInfo.LastName == LastName)
                    {
                        Console.WriteLine($"{item.StudentInfo.FirstName} {item.CourseInfo.CourseName}");
                    }
                }
            }
        }
    }
}
