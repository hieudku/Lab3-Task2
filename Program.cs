using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Lab3_Task2;

namespace Lab3_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle(1234, 4);
            v1 = new Vehicle("Hieu");
            v1.printFields();
            v1.changeSpeed(50.0);
            v1.stopVehicle();

            Vehicle v2 = new Vehicle(4567, 4);
            v1 = new Vehicle("Adya");
            v2.printFields();
            v1.changeSpeed(100.0);
            v1.stopVehicle();

            Vehicle v3 = new Vehicle(7891, 4);
            v1 = new Vehicle("Frances");
            v2.printFields();
            v1.changeSpeed(200.0);
            v1.stopVehicle();
        }



    }
}


