using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
   public class Car:Vehicle
    {
        private string automatic_or_gear;
        public string  Automatic_Or_Gear { get; set; }

        public Car()
        {

        }

        public Car(int registration_number, string color, int number_of_wheels, int model, string automatic_or_gear) :
            base(registration_number, color, number_of_wheels, model)
        {
            Automatic_Or_Gear= automatic_or_gear;
            Console.ReadLine();
        }
    }
}
