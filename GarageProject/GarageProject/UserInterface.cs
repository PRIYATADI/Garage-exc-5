
using GarageProject.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace GarageProject
{
    public class UserInterface
    {
        //  	{
        //class Program
        //    {
        /// <summary>
        /// The main method, will handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        public void CreateMainMenu()

        {


            bool run = true;
            while (run)
            {
                Console.Clear();
                Console.WriteLine("Please navigate through the menu by inputting the string \n(A, B, C) of your choice"
                    + "\nA. Navigate to all functionality of the garage"
                    + "\nB. Create a new garage with a specific size"
                    + "\nC. Close the application");


                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter your input!");
                }
                switch (input)
                {
                    case 'A':
                        NavigateThroughAllFunctionalityOfTheGarage();
                        break;
                    case 'B':
                        CreateNewGarage();
                        break;
                    case 'C':
                        return;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2)");
                        break;
                }
            }
        }
        //Navigate to all functionality of the garage 
        public void NavigateThroughAllFunctionalityOfTheGarage()
        {

            //public void SubMenu()

            {
                bool nav = true;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Please navigate through the menu by inputting the number \n(0, 1, 2, 3 ,4, 5, 6, 7) of your choice"
                        + "\n1. List all parked vehicles"
                        + "\n2. List all vehicles types currently parked in the garage"
                        + "\n3. Park specific vehicles in the garage"
                        + "\n4. Unpark specific vehicles from the garage"
                        + "\n5. Set maximum capacity (number of parking spaces in the garage) of the garage"
                        + "\n6. Search a vehicle depending on its properties in/from the garage"
                        + "\n7. List all vehicles in/from the garage with a required property"
                        + "\n0. Exit to the main menu");

                    char choise = ' '; //Creates the character input to be used with the switch-case below.
                    try
                    {
                        choise = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                    }
                    catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter some input!");
                    }
                    switch (choise)
                    {
                        case '1':
                            ListAllParkedVehicles();
                            break;
                        case '2':
                            ListAllVehiclesTypesCurrentlyParkedInTheGarage();
                            break;
                        case '3':
                            ParkSpecificVehiclesIntoTheGarage();
                            break;
                        case '4':
                            UnparkSpecificVehiclesFromTheGarage();
                            break;
                        case '5':
                              ;
                            break;
                        case '6':
                            SearchAVehicleIntoOrFromTheGarage();
                            break;
                        case '7':
                            ListAllVehiclesIntoOrFromTheGarageWithARequiredProperty();
                            break;
                        case '0':
                            return;
                        default:
                            Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4, 5, 6, 7, 0)");
                            break;
                    }
                }
                while (nav);
            }

        }


        public void ListAllParkedVehicles()
        {
            ;
        }

        public void ListAllVehiclesTypesCurrentlyParkedInTheGarage()
        {
            ;
        }
        public void ParcSpecificVehiclesIntoTheGarage()

        {
            do
            {
                Console.ReadLine();
                Console.WriteLine("Please input "); ;
            }


            public void UnparkSpecificVehiclesFromTheGarage()
            {
                ;
            }

            public void SetMaximumCapacityOfTheGarage()
            {
                ;
            }

            public void SearchAVehicleIntoOrFromTheGarage()
            {
                ;
            }
            public void ListAllVehiclesIntoOrFromTheGarageWithARequiredProperty()
            {
                ;
            }

            //Create a new garage with a specific size
            public void CreateTheSizeOfTheGarage()
            {
                Console.WriteLine("What is the garage maximum capacity?");
                Console.ReadLine();

            }



        }
    }