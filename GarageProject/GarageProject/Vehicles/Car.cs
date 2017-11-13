using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject.Vehicles
{
    public  class Car : Vehicle
    {
        private bool isDecapotabil;
        private bool isAutomatic;
        private bool harGear;

        public bool IsDecapotabil { set { isDecapotabil = value; } get { return isDecapotabil; } }
        public bool IsAutomatic { set { isAutomatic = value; } get { return isAutomatic; } }
        public bool HarGear { set { harGear = value; } get { return harGear; } }

        public Car()
        {

        }

        public Car(int id, string fName, string lName, string registrationNumber, string type, string model,
            int numberOfWheels, int numberOfSeats, int numberOfEngines,
            string color, DateTime parkingTime, DateTime unparkingTime, float parkingPeriod, bool isDecapotabil, bool isAutomatic, bool harGear) :
        base(id, fName, lName, registrationNumber, type, model,
           color, numberOfWheels, numberOfSeats, numberOfEngines, parkingTime, unparkingTime, parkingPeriod)
        {
            IsDecapotabil = isDecapotabil;
            IsAutomatic = isAutomatic;
            HarGear = harGear;
        }
       
        public override string VehicleInformations()
        {
            return base.VehicleInformations() + "\n Is Decapotabil: " + IsDecapotabil + "\n Is Automatic: "+ IsAutomatic + "\n Har Gear: " + HarGear;
        }

    }
}
