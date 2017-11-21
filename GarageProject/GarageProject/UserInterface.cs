
using GarageProject.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace GarageProject
{
    public class UserInterface : Vehicle
    {
        public void CreateMainMenu()
        {
            bool nav = true;
            do
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(0, 1, 2, 3 ,4, 5, 6, 7) of your choice"
                    + "\n1. Create New Garage by Setting maximum capacity (number of parking spaces in the garage) of the garage"
                    + "\n2. Park specific vehicles in the garage"
                    + "\n3. Unpark specific vehicles from the garage"
                    + "\n4. List all vehicles types currently parked in the garage"
                    + "\n5. List all parked vehicles"
                    + "\n6. Search a vehicle in the garage, depending on its properties"
                    + "\n7. List all vehicles in the garage with a required property"
                    + "\n0. Exit to the main menu");
                //char choise = ' ' *; //Creates the character input to be used with the switch-case below.
                //try
                //{
                //    char choise = Console.ReadLine()[0]; //Tries to set input to the first char in an input line

                //}
                //catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                //{
                //    //
                //    Console.WriteLine("Please enter some input!");
                //}
                string Choise = Console.ReadLine();
                int iChoice;
                if (int.TryParse(Choise, out iChoice))
                {
                    //Console.WriteLine("Invalid input!");
                    //Console.ReadLine();
                //}
                //else break;
               // Console.Clear();
              
                switch (iChoise)
                {
                    case '1':
                        CreateNewGarage();
                        break;
                    case '2':
                        ParkSpecificVehicle();
                        break;
                    case '3':
                        UnparkSpecificVehicle();
                        break;
                    case '4':
                        ListAllVehiclesTypesCurrentlyParked();
                        break;
                    case '5':
                        ListAllParkedVehicles(); ;
                        break;
                    case '6':
                        SearchAVehicleInGarage();
                        break;
                    case '7':
                        ListAllVehiclesInGarageWithARequiredProperty();
                        break;
                    case '0':
                         return;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4, 5, 6, 7, 0)");
                        Console.ReadLine();
                        break;
                }
            }
        }      
        while (nav);
    }   
     //Create a new garage by        
    //Setting maximum Capacity Of The Garage
    public int MaximumRequiredCapacity;
    private Garage<Vehicle> entireCapacity;
    public void CreateNewGarage()
     {
         do 
           {
            Console.Clear();
                Console.WriteLine("\n**********Create Garage****************\n");
            
                Console.WriteLine(" Type the capacity of the Garage, please.");
                string sMaximumSetCapacity = Console.ReadLine();
                while (!int.TryParse(sMaximumSetCapacity, out MaximumRequiredCapacity))
                {
                    if (MaximumRequiredCapacity <= 0)
                    {
                        Console.WriteLine("Invalid input, try again, please!");
                    }
                    sMaximumSetCapacity = Console.ReadLine();
                }
                entireCapacity = new Garage<Vehicle>(MaximumRequiredCapacity);
           

                Console.ReadLine();
                    Console.WriteLine("Press 0 to return to the main menu, please!");
                    Console.WriteLine("Press 1 to recreate the garage");
                    string newInput = Console.ReadLine();
                    switch (newInput)
                    {
                        case "1";
                            break;
                        case "0";
                            return;
                        default:
                            break;
                    }

         } while (true) ;
    }
     
    void ParkSpecificVehicle()
           
                {
                    Console.Clear();

                do
                {
                    Console.WriteLine("Type + to park a vehicle\n" +
                        "Type - to unpark a vehicle\n" + "Type 0 to return to the main menu.\n");
                    string navig = Console.ReadLine();
                    switch (navig)
                    {
                        case "+"://mother case
                            
                         Console.WriteLine("Please input 1 to park a airplane\n"+
                             "Please input 2 to park a boat\n" +
                             "Please input 3 to park a bus\n" +
                             "Please input 4 to park a car\n" +
                             "Please input 5 to park a helicopter\n" +
                             "Please input 6 to park a moped\n" +
                             "Please input 7 to park a motorcycle\n" +
                             "Please input 8 to park a van\n" +
                             "Please input 0 to return to the main menu\n");
                            string input = Console.ReadLine();
                            Console.WriteLine(" You choose {0}\n", input);
                            if (MaximumRequiredCapacity<=0)
                            {
                                Console.Clear();
                                Console.WriteLine("There is no garage to park in\n"+
                                    "Create a garage first!");
                            }
                            else
                            {
                                switch (input)
                                {
                                    //airplanes
                                    case "1": //child case of "+" case
                                        Console.WriteLine("\n1. You want to display a airplane ");
                                        Airplane newAirplane = new Airplane();
                                        Console.WriteLine("Type the your family name, please! ");
                                        var myAirplaneOwnerFName = Console.ReadLine();
                                        newAirplane.TheOwnerFName = myAirplaneOwnerFName;
                                        Console.WriteLine("Type the owner surname, please! ");
                                        var myAirplaneOwnerLName = Console.ReadLine();
                                        newAirplane.TheOwnerLName = myAirplaneOwnerLName;
                                        Console.WriteLine("Type the registration number, please! ");
                                        var myAirplaneRegistrationNumber = Console.ReadLine();
                                        newAirplane.RegistrationNumber = myAirplaneRegistrationNumber;
                                        Console.WriteLine("Type the model, please! ");
                                        var myAirplaneModel = Console.ReadLine();
                                        newAirplane.Model = myAirplaneModel;
                                        Console.WriteLine("Type the number of seats, please! ");
                                        var myAirplaneNumberOfSeats = Console.ReadLine();
                                        newAirplane.NumberOfSeats = int.Parse(myAirplaneNumberOfSeats);
                                        Console.WriteLine("Type the number of wheels, please! ");
                                        var myAirplaneNumberOfWheels = Console.ReadLine();
                                        newAirplane.NumberOfWheels = int.Parse(myAirplaneNumberOfWheels);
                                        Console.WriteLine("Type the number of windoors, please! ");
                                        var myAirplaneNumberOfWindoors = Console.ReadLine();
                                        newAirplane.NumberOfWindoors = int.Parse(myAirplaneNumberOfWindoors); 
                                        Console.WriteLine("Type the Id number, please! ");
                                        var myAirplaneId = Console.ReadLine();
                                        newAirplane.Id = int.Parse(myAirplaneId);
                                        Console.WriteLine("Type the number of engines, please! ");
                                        var myAirplanenumberOfEngines = Console.ReadLine();
                                        newAirplane.NumberOfEngines = int.Parse(myAirplanenumberOfEngines);
                                        Console.WriteLine("Type the color, please! ");
                                        var myAirplanecolor = Console.ReadLine();
                                        newAirplane.Color = myAirplanecolor;
                                        Console.WriteLine("Type the parking time, please! ");
                                        var myAirplaneParkingTime = Console.ReadLine();
                                        newAirplane.ParkingTime = DateTime.Parse(myAirplaneParkingTime);
                                        Console.WriteLine("Type unparking time, please! ");
                                        var myAirplaneUnparkingTime = Console.ReadLine();
                                        newAirplane.UnparkingTime = DateTime.Parse(myAirplaneUnparkingTime);
                                        Console.WriteLine("Type parking period, please! ");
                                        var myAirplaneParkingPeriod = Console.ReadLine();
                                        newAirplane.ParkingPeriod = int.Parse(myAirplaneParkingPeriod);
                                        Console.WriteLine("Type the wings length, please! ");
                                        var myAirplanewingsLength = Console.ReadLine();
                                        newAirplane.WingsLength = float.Parse(myAirplanewingsLength); 

                                        entireCapacity.ParkSpecificVehiclesInGarage(newAirplane);
                                        break;

                                    //boats
                                    case "2": //child case of "+" case
                                        Console.WriteLine("\n2. You want to refering at boat");
                                        Boat newBoat = new Boat();
                                        Console.WriteLine("Type the your family name, please!");
                                        var myBoattheOwnerFName = Console.ReadLine();
                                        newBoat.TheOwnerFName = myBoattheOwnerFName;
                                        Console.WriteLine("Type the owner surname, please!");
                                        var myBoatTheOwnerLName = Console.ReadLine();
                                        newBoat.TheOwnerLName = myBoatTheOwnerLName;
                                        Console.WriteLine("Type the registration number, please! ");
                                        var myBoatRegistrationNumber = Console.ReadLine();
                                        newBoat.RegistrationNumber = myBoatRegistrationNumber;
                                        Console.WriteLine("Type the model, please!");
                                        var myBoatmodel = Console.ReadLine();
                                        newBoat.Model = myBoatmodel;
                                        Console.WriteLine("Type the Id number, please!");
                                        var myBoatId = Console.ReadLine();
                                        newBoat.Id = int.Parse(myBoatId);
                                        Console.WriteLine("Type the color, please!");
                                        var myBoatcolor = Console.ReadLine();
                                        newBoat.Color = myBoatcolor;
                                        Console.WriteLine("Type the number of seats, please! ");
                                        var myBoatnumberOfSeats = Console.ReadLine();
                                        newBoat.NumberOfSeats = int.Parse(myBoatnumberOfSeats);
                                        Console.WriteLine("Type the number of wheels, please! ");
                                        var myBoatnumberOfWheels = Console.ReadLine();
                                        newBoat.NumberOfWheels = int.Parse(myBoatnumberOfWheels);
                                        Console.WriteLine("Type the number of engines, please! ");
                                        var myBoatnumberOfEngines = Console.ReadLine();
                                        newBoat.NumberOfEngines = int.Parse(myBoatnumberOfEngines);
                                        Console.WriteLine("Type 'true' if your boat has mast or \n" +
                                            "'false' if it doesn't, please! ");
                                        var myBoatWithMast = Console.ReadLine();
                                        newBoat.WithMast = bool.Parse(myBoatWithMast);
                                        Console.WriteLine("Type 'true' if your boat has motor or \n" +
                                            "'false' if it doesn't, please! ");
                                        var myBoatwithMotor = Console.ReadLine();
                                        newBoat.withMotor = bool.Parse(myBoatwithMotor);
                                        entireCapacity.ParkSpecificVehiclesInGarage(newBoat);
                                        break;

                                    //bus

                                    case "3": //child case of "+" case
                                        Console.WriteLine("\n3. You want to display a bus");
                                        Bus newBus = new Bus();
                                        Console.WriteLine("Type the your family name, please! ");
                                        var myBusOwnerFName = Console.ReadLine();
                                        newBus.TheOwnerFName = myBusOwnerFName;
                                        Console.WriteLine("Type the owner surname, please! ");
                                        var myBusOwnerLName = Console.ReadLine();
                                        newBus.TheOwnerLName = myBusOwnerLName;
                                        Console.WriteLine("Type the registration number, please! ");
                                        var myBusRegistrationNumber = Console.ReadLine();
                                        newBus.RegistrationNumber = myBusRegistrationNumber;
                                        Console.WriteLine("Type the model, please! ");
                                        var myBusModel = Console.ReadLine();
                                        newBus.Model = myBusModel;
                                        Console.WriteLine("Type the number of seats, please! ");
                                        var myBusNumberOfSeats = Console.ReadLine();
                                        newBus.NumberOfSeats = int.Parse(myBusNumberOfSeats);
                                        Console.WriteLine("Type the number of wheels, please! ");
                                        var myBusNumberOfWheels = Console.ReadLine();
                                        newBus.NumberOfWheels = int.Parse(myBusNumberOfWheels);
                                        Console.WriteLine("Type the height of your bus, please! ");
                                        var myBusHeight = Console.ReadLine();
                                        newBus.Height = float.Parse(myBusHeight); 
                                        Console.WriteLine("Type the Id number, please! ");
                                        var myBusId = Console.ReadLine();
                                        newBus.Id = int.Parse(myBusId);
                                        Console.WriteLine("Type the number of engines, please! ");
                                        var myBusnumberOfEngines = Console.ReadLine();
                                        newBus.NumberOfEngines = int.Parse(myBusnumberOfEngines);
                                        Console.WriteLine("Type the color, please! ");
                                        var myBuscolor = Console.ReadLine();
                                        newBus.Color = myBuscolor;
                                        Console.WriteLine("Type the parking time, please! ");
                                        var myBusParkingTime = Console.ReadLine();
                                        newBus.ParkingTime = DateTime.Parse(myBusParkingTime);
                                        Console.WriteLine("Type unparking time, please! ");
                                        var myBusUnparkingTime = Console.ReadLine();
                                        newBus.UnparkingTime = DateTime.Parse(myBusUnparkingTime);
                                        Console.WriteLine("Type parking period, please! ");
                                        var myBusParkingPeriod = Console.ReadLine();
                                        newBus.ParkingPeriod = int.Parse(myBusParkingPeriod);
                                        Console.WriteLine("Type the number of double seats, please! ");
                                        var myBusNumberOfDoubleSeats = Console.ReadLine();
                                        newBus.NumberOfDoubleSeats = int.Parse(myBusNumberOfDoubleSeats); 

                                        entireCapacity.ParkSpecificVehiclesInGarage(newBus);
                                        break;
                                  
                                   // cars

                                    case "4": //child case of "+" case
                                        Console.WriteLine("\n4.You want to park a Car");
                                        Car newCar = new Car();
                                        Console.WriteLine("Type the your family name, please! ");
                                        var myCarOwnerFName = Console.ReadLine();
                                        newCar.TheOwnerFName = myCarOwnerFName;
                                        Console.WriteLine("Type the owner surname, please! ");
                                        var myCarOwnerLName = Console.ReadLine();
                                        newCar.TheOwnerLName = myCarOwnerLName;
                                        Console.WriteLine("Type the registration number, please! ");
                                        var myCarRegistrationNumber = Console.ReadLine();
                                        newCar.RegistrationNumber = myCarRegistrationNumber;
                                        Console.WriteLine("Type the model, please! ");
                                        var myCarModel = Console.ReadLine();
                                        newCar.Model = myCarModel;
                                        Console.WriteLine("Type the number of seats, please! ");
                                        var myCarNumberOfSeats = Console.ReadLine();
                                        newCar.NumberOfSeats = int.Parse(myCarNumberOfSeats);
                                        Console.WriteLine("Type the number of wheels, please! ");
                                        var myCarNumberOfWheels = Console.ReadLine();
                                        newCar.NumberOfWheels = int.Parse(myCarNumberOfWheels);
                                        Console.WriteLine("Type if your car is decapotabil or not, please! ");
                                        var myCarIsDecapotabil = Console.ReadLine();
                                        newCar.IsDecapotabil = bool.Parse(myCarIsDecapotabil);
                                        Console.WriteLine("Type the Id number, please! ");
                                        var myCarId = Console.ReadLine();
                                        newCar.Id = int.Parse(myCarId);
                                        Console.WriteLine("Type the number of engines, please! ");
                                        var myCarNumberOfEngines = Console.ReadLine();
                                        newCar.NumberOfEngines = int.Parse(myCarNumberOfEngines);
                                        Console.WriteLine("Type the color, please! ");
                                        var myCarcolor = Console.ReadLine();
                                        newCar.Color = myCarcolor;
                                        Console.WriteLine("Type the parking time, please! ");
                                        var myCarParkingTime = Console.ReadLine();
                                        newCar.ParkingTime = DateTime.Parse(myCarParkingTime);
                                        Console.WriteLine("Type unparking time, please! ");
                                        var myCarUnparkingTime = Console.ReadLine();
                                        newCar.UnparkingTime = DateTime.Parse(myCarUnparkingTime);
                                        Console.WriteLine("Type parking period, please! ");
                                        var myCarParkingPeriod =Console.ReadLine();
                                        newCar.ParkingPeriod = float.Parse(myCarParkingPeriod);
                                        Console.WriteLine("Type if your car is automatic or gear, please! ");
                                        var myCarIsAutomaticOrGear = Console.ReadLine();
                                        newCar.IsAutomaticOrGear = myCarIsAutomaticOrGear;
                                        entireCapacity.ParkSpecificVehiclesInGarage(newCar);
                                        break;
                                      
                                    //helicopters
                                    case "5":
                                        Console.WriteLine("\n5. You want to display a helicopter ");
                                        Helicopter newHelicopter = new Helicopter();
                                        Console.WriteLine("Type the your helicopter owner family name, please! ");
                                        var myHelicopterOwnerFName = Console.ReadLine();
                                        newHelicopter.TheOwnerFName = myHelicopterOwnerFName;
                                        Console.WriteLine("Type the owner surname, please! ");
                                        var myHelicopterOwnerLName = Console.ReadLine();
                                        newHelicopter.TheOwnerLName = myHelicopterOwnerLName;
                                        Console.WriteLine("Type the registration number, please! ");
                                        var myHelicopterRegistrationNumber = Console.ReadLine();
                                        newHelicopter.RegistrationNumber = myHelicopterRegistrationNumber;
                                        Console.WriteLine("Type the model, please! ");
                                        var myHelicopterModel = Console.ReadLine();
                                        newHelicopter.Model = myHelicopterModel;
                                        Console.WriteLine("Type the number of seats, please! ");
                                        var myHelicopterNumberOfSeats = Console.ReadLine();
                                        newAirplane.NumberOfSeats = int.Parse(myHelicopterNumberOfSeats);
                                        Console.WriteLine("Type the number of wheels, please! ");
                                        var myHelicopterNumberOfWheels = Console.ReadLine();
                                        newAirplane.NumberOfWheels = int.Parse(myHelicopterNumberOfWheels);
                                        Console.WriteLine("Type the number of windoors, please! ");
                                        var myHelicopterNumberOfWings = Console.ReadLine();
                                        newHelicopter.NumberOfWings = int.Parse(myHelicopterNumberOfWings);
                                        Console.WriteLine("Type the Id number, please! ");
                                        var myHelicopterId = Console.ReadLine();
                                        newHelicopter.Id = int.Parse(myHelicopterId);
                                        Console.WriteLine("Type the number of engines, please! ");
                                        var myHelicopternumberOfEngines = Console.ReadLine();
                                        newHelicopter.NumberOfEngines = int.Parse(myHelicopternumberOfEngines);
                                        Console.WriteLine("Type the color, please! ");
                                        var myHelicoptercolor = Console.ReadLine();
                                        newAirplane.Color = myHelicoptercolor;
                                        Console.WriteLine("Type the parking time, please! ");
                                        var myHelicopterParkingTime = Console.ReadLine();
                                        newAirplane.ParkingTime = DateTime.Parse(myHelicopterParkingTime);
                                        Console.WriteLine("Type unparking time, please! ");
                                        var myHelicopterUnparkingTime = Console.ReadLine();
                                        newHelicopter.UnparkingTime = DateTime.Parse(myHelicopterUnparkingTime);
                                        Console.WriteLine("Type parking period, please! ");
                                        var myHelicopterParkingPeriod = Console.ReadLine();
                                        newHelicopter.ParkingPeriod = float.Parse(myHelicopterParkingPeriod);
                                        Console.WriteLine("Type the width, please! ");
                                        var myHelicopterWidth = Console.ReadLine();
                                        newHelicopter.Width = float.Parse(myHelicopterWidth);
                                        entireCapacity.ParkSpecificVehiclesInGarage(newHelicopter);
                                        break;
                                     
                                                                       
                                //moped
                                    case "6": //child case of "+" case
                                        Console.WriteLine("\n6. You want to display a moped");
                                        Moped newMoped = new Moped();
                                        Console.WriteLine("Type the your family name, please! ");
                                        var myMopedOwnerFName = Console.ReadLine();
                                        newMoped.TheOwnerFName = myMopedOwnerFName;
                                        Console.WriteLine("Type the owner surname, please! ");
                                        var myMopedOwnerLName = Console.ReadLine();
                                        newMoped.TheOwnerLName = myMopedOwnerLName;
                                        Console.WriteLine("Type the registration number, please! ");
                                        var myMopedRegistrationNumber = Console.ReadLine();
                                        newMoped.RegistrationNumber = myMopedRegistrationNumber;
                                        Console.WriteLine("Type the model, please! ");
                                        var myMopedModel = Console.ReadLine();
                                        newMoped.Model = myMopedModel;
                                        Console.WriteLine("Type the number of seats, please! ");
                                        var myMopedNumberOfSeats = Console.ReadLine();
                                        newMoped.NumberOfSeats = int.Parse(myMopedNumberOfSeats);
                                        Console.WriteLine("Type the number of wheels, please! ");
                                        var myMopedNumberOfWheels = Console.ReadLine();
                                        newMoped.NumberOfWheels = int.Parse(myMopedNumberOfWheels);
                                        Console.WriteLine("Type the lenght of your moped, please! ");
                                        var myMopedLenght = Console.ReadLine();
                                        newMoped.Length = float.Parse(myMopedLenght);
                                        Console.WriteLine("Type the Id number, please! ");
                                        var myMopedId = Console.ReadLine();
                                        newMoped.Id = int.Parse(myMopedId);
                                        Console.WriteLine("Type the number of engines, please!");
                                        var myMopednumberOfEngines = Console.ReadLine();
                                        newMoped.NumberOfEngines = int.Parse(myMopednumberOfEngines);
                                        Console.WriteLine("Type the color, please!");
                                        var myMopedcolor = Console.ReadLine();
                                        newMoped.Color = myMopedcolor;
                                        Console.WriteLine("Type the parking time, please!");
                                        var myMopedParkingTime = Console.ReadLine();
                                        newMoped.ParkingTime = DateTime.Parse(myMopedParkingTime);
                                        Console.WriteLine("Type unparking time, please!");
                                        var myMopedUnparkingTime = Console.ReadLine();
                                        newMoped.UnparkingTime = DateTime.Parse(myMopedUnparkingTime);
                                        Console.WriteLine("Type parking period, please!");
                                        var myMopedParkingPeriod = Console.ReadLine();
                                        newMoped.ParkingPeriod = float.Parse(myMopedParkingPeriod);
                                        Console.WriteLine("Type the FuelType, please!");
                                        var myMopedFuelType = Console.ReadLine();
                                        newMoped.FuelType = myMopedFuelType;
                                        entireCapacity.ParkSpecificVehiclesInGarage(newMoped);
                                        break;
                                        

                                    //motorcycles

                                    case "7": //child case of "+" case
                                        Console.WriteLine("\n7. You want to display a motocycle");
                                        Motorcycle newMotorcycle = new Motorcycle();
                                        Console.WriteLine("Type the your family name, please! ");
                                        var myMotorcycleOwnerFName = Console.ReadLine();
                                        newMotorcycle.TheOwnerFName = myMotorcycleOwnerFName;
                                        Console.WriteLine("Type the owner surname, please! ");
                                        var myMotorcycleOwnerLName = Console.ReadLine();
                                        newMotorcycle.TheOwnerLName = myMotorcycleOwnerLName;
                                        Console.WriteLine("Type the registration number, please! ");
                                        var myMotorcycleRegistrationNumber = Console.ReadLine();
                                        newMotorcycle.RegistrationNumber = myMotorcycleRegistrationNumber;
                                        Console.WriteLine("Type the model, please! ");
                                        var myMotorcycleModel = Console.ReadLine();
                                        newMotorcycle.Model = myMotorcycleModel;
                                        Console.WriteLine("Type the number of seats, please! ");
                                        var myMotocycleNumberOfSeats = Console.ReadLine();
                                        newMotorcycle.NumberOfSeats = int.Parse(myMotorcycleNumberOfSeats);
                                        Console.WriteLine("Type the number of wheels, please! ");
                                        var myMotorcycleNumberOfWheels = Console.ReadLine();
                                        newMotorcycle.NumberOfWheels = int.Parse(myMotorcycleNumberOfWheels);
                                        Console.WriteLine("Type the Speed of your motorcycle, please! ");
                                        var myMotorcycleSpeed = Console.ReadLine();
                                        newMotorcycle.Speed = float.Parse(myMotorcycleSpeed);
                                        Console.WriteLine("Type the Id number, please! ");
                                        var myMotorcycleId = Console.ReadLine();
                                        newMotorcycle.Id = int.Parse(myMotorcycleId);
                                        Console.WriteLine("Type the number of engines, please!");
                                        var myMotorcyclenumberOfEngines = Console.ReadLine();
                                        newMotorcycle.NumberOfEngines = int.Parse(myMotorcyclenumberOfEngines);
                                        Console.WriteLine("Type the color, please!");
                                        var myMotorcyclecolor = Console.ReadLine();
                                        newMotorcycle.Color = myMotorcyclecolor;
                                        Console.WriteLine("Type the parking time, please!");
                                        var myMotorcycleParkingTime = Console.ReadLine();
                                        newMotorcycle.ParkingTime = DateTime.Parse(myMotorcycleParkingTime);
                                        Console.WriteLine("Type unparking time, please!");
                                        var myMotorcycleUnparkingTime = Console.ReadLine();
                                        newMotorcycle.UnparkingTime = DateTime.Parse(myMotorcycleUnparkingTime);
                                        Console.WriteLine("Type parking period, please!");
                                        var myMotorcycleParkingPeriod = Console.ReadLine();
                                        newMotorcycle.ParkingPeriod = float.Parse(myMotorcycleParkingPeriod);
                                        Console.WriteLine("Type the motocycle lenght, please!");
                                        var myMotorcyclemotoLenght = Console.ReadLine();
                                        newMotorcycle.MotoLenght = float.Parse(myMotorcyclemotoLenght);
                                        entireCapacity.ParkSpecificVehiclesInGarage(newMotorcycle);
                                        break;
                                       
                                    //Vans

                                    case "8": //child case of "+" case
                                        Console.WriteLine("\n8. You want to display a Van");
                                        Van newVan = new Van();
                                        Console.WriteLine("Type the your family name, please! ");
                                        var myVanOwnerFName = Console.ReadLine();
                                        newVan.TheOwnerFName = myVanOwnerFName;
                                        Console.WriteLine("Type the owner surname, please! ");
                                        var myVanOwnerLName = Console.ReadLine();
                                        newVan.TheOwnerLName = myVanOwnerLName;
                                        Console.WriteLine("Type the registration number, please! ");
                                        var myVanRegistrationNumber = Console.ReadLine();
                                        newVan.RegistrationNumber = myVanRegistrationNumber;
                                        Console.WriteLine("Type the model, please! ");
                                        var myVanModel = Console.ReadLine();
                                        newVan.Model = myVanModel;
                                        Console.WriteLine("Type the number of seats, please! ");
                                        var myVanNumberOfSeats = Console.ReadLine();
                                        newVan.NumberOfSeats = int.Parse(myVanNumberOfSeats);
                                        Console.WriteLine("Type the number of wheels, please! ");
                                        var myVanNumberOfWheels = Console.ReadLine();
                                        newVan.NumberOfWheels = int.Parse(myVanNumberOfWheels);
                                        Console.WriteLine("Type the Id number, please! ");
                                        var myVanId = Console.ReadLine();
                                        newVan.Id = int.Parse(myVanId);
                                        Console.WriteLine("Type the number of engines, please!");
                                        var myVannumberOfEngines = Console.ReadLine();
                                        newVan.NumberOfEngines = int.Parse(myVannumberOfEngines);
                                        Console.WriteLine("Type the color, please!");
                                        var myVancolor = Console.ReadLine();
                                        newVan.Color = myVancolor;
                                        Console.WriteLine("Type the parking time, please!");
                                        var myVanParkingTime = Console.ReadLine();
                                        newVan.ParkingTime = DateTime.Parse(myVanParkingTime);
                                        Console.WriteLine("Type unparking time, please!");
                                        var myVanUnparkingTime = Console.ReadLine();
                                        newVan.UnparkingTime = DateTime.Parse(myVanUnparkingTime);
                                        Console.WriteLine("Type parking period, please!");
                                        var myVanParkingPeriod = Console.ReadLine();
                                        newVan.ParkingPeriod = float.Parse(myVanParkingPeriod);
                                        Console.WriteLine("Type there are Places For Children, please!");
                                        var myVanWithSpecialPlacesForChildren = Console.ReadLine();
                                        newVan.WithSpecialPlacesForChildren = bool.Parse(myVanWithSpecialPlacesForChildren);
                                        entireCapacity.ParkSpecificVehiclesInGarage(newVan);
                                        break;
                                    //
                                        case "0": //child case of "+" case
                                        Console.WriteLine("Please, return one step back!\n");
                                        return;
                                    //
                                    case "9":
                                        Console.WriteLine("Clean the window.");
                                        break;
                                    default://child case of "+" case
                                        Console.WriteLine("Invalid input, type only something from optins");
                                        break;
                                     //
                                }
                            }

                            break;//this is for +

                            //string choice1 = Console.ReadLine();
                    }

                }
                while (true);

        }
         
    void UnparkSpecificVehicle()
            {
                ;
            }
    void ListAllParkedVehicles()
        {
            ;
        }
    void ListAllVehiclesTypesCurrentlyParked()
        {
            ;
        }
    void SearchAVehicleInGarage()
    void ListAllVehiclesInGarageWithARequiredProperty()
     {
     ;
     }
    }
              
}
  