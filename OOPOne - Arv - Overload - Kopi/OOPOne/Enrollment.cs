using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOne
{
    public class Enrollment : IComparable<Enrollment>
    {
        public Enrollment(Student studentInfo, Course courseInfo)
        {
            StudentInfo = studentInfo;
            CourseInfo = courseInfo;
        }

        public Enrollment()
        {

        }
        public Student StudentInfo { get; set; }

        public Course CourseInfo { get; set; }

        public List<Enrollment> Enrollments { get;set; }

        public int CompareTo(Enrollment other)
        {
            if(other != null)
            {
            return string.Compare (StudentInfo.FirstName, other.StudentInfo.FirstName);
            }
            else
            {
                return 0;
            }
        }
    }
}
