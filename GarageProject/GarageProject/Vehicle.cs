using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
   public class Vehicle
    {
        private int registration_number;
        private string color;
        private int number_of_wheels;
        private int model;

        public int Registration_Number { get; set; }
        public string Color { get; set; }
        public int Number_Of_Wheels { get; set; }
        public int Model { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(int registration_number, string color, int number_of_wheels, int model)
        {
            Registration_Number=registration_number;
            Color = color;
            Number_Of_Wheels = number_of_wheels;
            Model = model;

            Console.ReadLine();
        }
    }
}
