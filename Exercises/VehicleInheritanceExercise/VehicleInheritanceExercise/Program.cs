using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInheritanceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            FourWheeled car = new FourWheeled();
            car.ChangeColor();

            car.StartVehicle();

            car.RunAtFullSpeed();
        }
    }
}
