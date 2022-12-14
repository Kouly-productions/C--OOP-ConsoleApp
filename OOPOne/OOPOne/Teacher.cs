using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPOne
{
    public class Teacher
    {
		private string _Detpartment;
        private string _Name;
        private string _LastName;
        private DateTime _DateOfTime;
        private int _Age;

        public Teacher(string department, string name, string lastName, DateTime dateoftime, int age)
        {
            Department = department;
            Name = name;
            LastName = lastName;
            DateOfTime = dateoftime;
            Age = age;
        }

		public string Department
		{
			get { return _Detpartment; }
			set { _Detpartment = value; }
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
