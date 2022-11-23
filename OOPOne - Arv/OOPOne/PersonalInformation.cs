using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOne
{
    public class PersonalInformation
    {
		private string _Firstname;
		private string _LastName;
        private int _Age;

        public PersonalInformation(string firstName, string lastName, int age)
        {
            FirstName= firstName;
            LastName= lastName;
            Age= age;
        }

		public string FirstName
		{
			get { return _Firstname; }
			set { _Firstname = value; }
		}


		public string LastName
		{
			get { return _LastName; }
			set { _LastName = value; }
		}

        public DateTime DateOfTime { get; set; }

        public int Age
        {
            get
            {
                double antalDage = (DateTime.Now - DateOfTime).TotalDays;
                int _Age = (int)antalDage / 365;
                return _Age;
            }

            set { _Age = value; }
        }

    }
}
