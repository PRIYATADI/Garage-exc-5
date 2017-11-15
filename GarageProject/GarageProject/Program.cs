using GarageProject.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    class Program
    {
        /// <summary>
        /// The main method, will handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            {
             UserInterface control = new UserInterface();
             control.CreateMainMenu();
            }
            Console.ReadLine();
            {
                //CreateNewGarage
                UserInterface1 control1 = new UserInterface1();
                control1.CreateNewGarage();
            }
            Console.ReadLine();
        }
     }
  }
    