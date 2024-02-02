using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SportCar sportCar = new SportCar("Sportcar", 10);
            sportCar.Racing();
            Passeger passeger = new Passeger("Car", 8);
            passeger.Racing();
            Bus bus = new Bus("Bus", 6);
            bus.Racing();
            Track track = new Track("Gruzovik", 4);
            track.Racing();

            if (sportCar.unitOfCalculation < passeger.unitOfCalculation && sportCar.unitOfCalculation < bus.unitOfCalculation && sportCar.unitOfCalculation < track.unitOfCalculation)
            {
                sportCar.Finish();
            }

            if (passeger.unitOfCalculation < sportCar.unitOfCalculation && passeger.unitOfCalculation < bus.unitOfCalculation && passeger.unitOfCalculation < track.unitOfCalculation)
            {
                passeger.Finish();
            }

            if (bus.unitOfCalculation < passeger.unitOfCalculation && bus.unitOfCalculation < sportCar.unitOfCalculation && bus.unitOfCalculation < track.unitOfCalculation)
            {
                bus.Finish();
            }

            if (track.unitOfCalculation < passeger.unitOfCalculation && track.unitOfCalculation < bus.unitOfCalculation && track.unitOfCalculation < sportCar.unitOfCalculation)
            {
                track.Finish();
            }

            Console.ReadKey();
        }
    }
}