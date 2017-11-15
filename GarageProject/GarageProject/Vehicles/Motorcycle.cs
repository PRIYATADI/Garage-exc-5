using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject.Vehicles
{
    public class Motorcycle : Vehicle
    {
        private float speed;
        private float motoLenght;

        public float Speed { set { speed = value; } get { return speed; } }
        public float MotoLenght { set { motoLenght = value; } get { return motoLenght; } } 

        public Motorcycle()
        {

        }

        public Motorcycle(int id, string fName, string lName, string registrationNumber, string type, string model, 
                          int numberOfWheels, int numberOfSeats, int numberOfEngines, string color, DateTime parkingTime,
                          DateTime unparkingTime, float parkingPeriod, float speed, float motoLenght):
        base(id, fName, lName, registrationNumber, type, model, color, numberOfWheels,
            numberOfSeats, numberOfEngines, parkingTime, unparkingTime, parkingPeriod)
        {
            Speed = speed;
            MotoLenght = motoLenght;
        }

        public override string VehicleInformations()
        {
            return base.VehicleInformations() + "\nSpeed is: " + Speed + "\nMotoLenght is: " + MotoLenght;
        }
    }
}
