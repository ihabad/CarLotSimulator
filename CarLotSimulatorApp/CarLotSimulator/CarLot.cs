using System.Collections.Generic;
using System.ComponentModel;

namespace CarLotSimulator
{
    internal class CarLot
    {

        public CarLot()
        {

        }
        public static int numberOfCars = 0;

        public List<Car> Carlot { get; set; } = new List<Car>();

    }
}

