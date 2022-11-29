using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case2
{
    public class Customer : PersonalInformation
    {
        public Customer(string firstName, string lastName, int phoneNumber) : base(firstName, lastName, phoneNumber)
        {
            
        }
    }
}
