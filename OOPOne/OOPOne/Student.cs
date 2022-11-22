using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OOPOne
{
    public class Student
    {
		public Student(int studentId, string name, string lastname, DateTime dateoftime, int age)
		{
			StudentId = studentId;
			Name = name;
			LastName = lastname;
			DateOfTime = dateoftime;
			Age = age;
		}

		private int _StudentId;
		private string _Name;
		private string _LastName;
		private int _Age;
		

		public int StudentId
		{
			get { return _StudentId; }
			set { _StudentId = value; }
		}


		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

		public string LastName
		{
			get { return _LastName; }
			set { _LastName = value; }
		}

		public DateTime DateOfTime { get; set; }

		public int Age
		{
			get { 

				double antalDage = (DateTime.Now - DateOfTime).TotalDays;
				int _Age = (int)antalDage / 365;
                return _Age; }

			set { _Age = value; }
		}
	}
}
