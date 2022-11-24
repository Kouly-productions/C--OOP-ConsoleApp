using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOne
{
    public class Course
    {

		public Course(CourseEnum name, Teacher teacher)
		{
            CourseName = name;
            TeacherInfo = teacher;
		}

		public CourseEnum CourseName
		{
			get;
			set;
		}

		private Teacher _TeacherInfo;

		public  Teacher TeacherInfo
		{
			get { return _TeacherInfo; }
			set { _TeacherInfo = value; }
		}


	}
}
