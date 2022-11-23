using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOne
{
    public class Course
    {
		public Course(string courseName, Teacher teacherInfo)
		{
			CourseName = courseName;
            TeacherInfo = teacherInfo;
		}

		private string _CourseName;

		public string CourseName
		{
			get { return _CourseName; }
			set { _CourseName = value; }
		}

		private Teacher _TeacherInfo;

		public Teacher TeacherInfo
		{
			get { return _TeacherInfo; }
			set { _TeacherInfo = value; }
		}
	}
}
