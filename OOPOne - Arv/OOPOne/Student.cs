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
	}
}
