using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    public class Motorcycle:Vehicle
    {
        private string fuel_type;
        public string Fuel_Type { get; set; }

        public Motorcycle()
        {

        }

        public Motorcycle(int registration_number, string color, int number_of_wheels, int model, string fuel_type):
            base(registration_number, color, number_of_wheels, model)
        {
            Fuel_Type= fuel_type;
            Console.ReadLine();
        }

    }
}
