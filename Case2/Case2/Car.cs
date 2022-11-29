using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Case2
{
    public class Car
    {
        public Car(string brand, string carType, int numberPlate)
        {
            Brand = brand;
            CarType = carType;
            NumberPlate = numberPlate;
        }

        public string Brand { get; set; }
        public string CarType { get; set; }
        public int NumberPlate { get; set; }
    } 
}
