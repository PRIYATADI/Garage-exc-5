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
        private string isAutomaticOrGear;
      

        public bool IsDecapotabil { set { isDecapotabil = value; } get { return isDecapotabil; } }
        public string IsAutomaticOrGear { set { isAutomaticOrGear = value; } get { return isAutomaticOrGear; } }
       

        public Car()
        {

        }

        public Car(int id, string fName, string lName, string registrationNumber, string type, string model,
            int numberOfWheels, int numberOfSeats, int numberOfEngines,
            string color, DateTime parkingTime, DateTime unparkingTime, float parkingPeriod, bool isDecapotabil, 
            string isAutomaticOrGearGear) :
        base(id, fName, lName, registrationNumber, type, model,
           color, numberOfWheels, numberOfSeats, numberOfEngines, parkingTime, unparkingTime, parkingPeriod)
        {
            IsDecapotabil = isDecapotabil;
            IsAutomaticOrGear = isAutomaticOrGear;
           
        }
       
        public override string VehicleInformations()
        {
            return base.VehicleInformations() + "\n Is Decapotabil: " + IsDecapotabil + 
                "\n Is AutomaticOrGear: " + IsAutomaticOrGear;
        }

    }
}
