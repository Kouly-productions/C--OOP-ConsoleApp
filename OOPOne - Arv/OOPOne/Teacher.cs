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

        public Teacher(string department, string firstName, string lastName, DateTime dateoftime, int age) : base(firstName, lastName, age)
        {
            Department = department;
            FirstName = firstName;
            LastName = lastName;
            DateOfTime = dateoftime;
            Age = age;
        }

		public string Department
		{
			get { return _Detpartment; }
			set { _Detpartment = value; }
		}
    }
}
