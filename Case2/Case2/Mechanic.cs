using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Case2
{
    public class Mechanic : PersonalInformation
    {
        public Mechanic(string firstName, string lastName, int phoneNumber, CarLogoEnum mechanicType) : base(firstName, lastName, phoneNumber)
        {
            MechanicType = mechanicType;
        }
        public CarLogoEnum MechanicType { get; set; }
    }
}
