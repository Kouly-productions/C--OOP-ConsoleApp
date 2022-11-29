using System;

namespace Case2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mechanic Martin = new Mechanic("Martin", "Jensen", 11111111, CarLogoEnum.Bil);
            Mechanic Thomas = new Mechanic("Thomas", "Hansen", 22222222, CarLogoEnum.Mortercykel);
            Mechanic Henrik = new Mechanic("Henrik", "Nielsen", 33333333, CarLogoEnum.Lastbil);


            Enrollment x = new();

            Console.WriteLine("Skriv dit fornavn");
            string firstname = Console.ReadLine();
            Console.WriteLine("Skriv dit efternavn");
            string lanstname = Console.ReadLine();
            Console.WriteLine("Skriv dit telefonummer");
            int phonenumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv nummerplade");
            int numberplate = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv bilens mærke");
            string brand = Console.ReadLine();
            Console.WriteLine("Skriv bilens model");
            string model = Console.ReadLine();
            Console.WriteLine("skriv bilens registerings årgang");
            DateTime year = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Skriv køretøjs type (Bil, Lastbil, Motorcykel)");
            string viechle = Console.ReadLine();

            Console.Clear();
        }
    } 
}