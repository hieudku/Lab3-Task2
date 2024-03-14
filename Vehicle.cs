using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Task2
{
    internal class Vehicle
    {
        // static fields
        private static int vehicleID;

        private const int wheels = 4;
        private static string name;
        public static int VehicleID { get => vehicleID; set => vehicleID = value; } // can be changed and read

        public static int Wheels => wheels; // should not be changed only read

        public Vehicle(int ID, int wheels)
        {
            vehicleID = ID;
            wheels = 4;
        }
        public Vehicle(String ownerName)
        {
            name = ownerName;
        }
        public void printFields()
        {
            Console.WriteLine($"Vehicle's ID is {vehicleID} and its number of wheels is {wheels}");
            Console.WriteLine($"Vehicle's owner name is {name}");
        }
        public double changeSpeed(double speed)
        {
            double s = speed;
            Console.WriteLine($"Vehicle's speed  = {speed}");
            return s;
        }
        public double stopVehicle()
        {
            Console.WriteLine($"Vehicle's speed = 0, stopped");
            return 0;
        }
    }
}
