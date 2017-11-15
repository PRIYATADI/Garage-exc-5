using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject.Vehicles
{
    public class Helicopter : Vehicle
    {
        private string helicType;
        private int numberOfWings;
        private float width;
                
        public int NumberOfWings { set { numberOfWings = value; } get { return numberOfWings; } }
        public float Width { set { width = value; } get { return width; } }

        public Helicopter()
        {

        }

        public Helicopter(int id, string fName, string lName, string registrationNumber, string type, string model, 
            int numberOfWheels, int numberOfSeats, int numberOfEngines, string color, DateTime parkingTime,
            DateTime unparkingTime, float parkingPeriod, int numberOfWings, float width) :
        base(id, fName, lName, registrationNumber, type, model, color, numberOfWheels,
           numberOfSeats, numberOfEngines, parkingTime, unparkingTime, parkingPeriod)
        {
            NumberOfWings = numberOfWings;
            Width = width;
        }

        public override string VehicleInformations()
        {
            return base.VehicleInformations() + "\nNumber of Wings is: " + numberOfWings + "\n Width is: " + Width;
        }
    }
}