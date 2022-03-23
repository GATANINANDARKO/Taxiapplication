using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();
            taxi.DriverName = "gatan";
            taxi.OnDuty = false;
            taxi.NumPasangger = 5;

            taxi.TaxiInfo();
            taxi.PickUpPasangger();
            taxi.DropOffPasangger();
            Console.ReadKey();

        }
    
     }
}
