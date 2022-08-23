using System;

namespace CarLotSimulator
{
    class Program
    {
        private static object myCar;

        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.


            //At the end iterate through the list printing each of car's Year, Make, and Model to the console


            Car secondCar = new Car()
            {
                Year = 2016,
                Model = "Sonata",
                Make = "Hyundai",
                EngineNoise = "Random",
                HonkNoise = "Loud",
                IsDriveable = true,
            };


            var ThirdCar = new Car(2019, "I8", "Power", "Pure Sound", true);

           
            secondCar.MakingEngineNoise(secondCar.EngineNoise);
            ThirdCar.MakingEngineNoise(ThirdCar.EngineNoise);


            var lot = new CarLot();


            lot.Carlot.Add((Car)myCar);

            lot.Carlot.Add(secondCar);

            lot.Carlot.Add(ThirdCar);

            Console.WriteLine($"Take a look at the number of cars: {CarLot.numberOfCars}");


            foreach (var car in lot.Carlot)
            {
                Console.WriteLine($"It is my car's  {car.Make} and model {car.Model} was built in  {car.Year} and it has {car.EngineNoise} and honking noise {car.HonkNoise}");
            }

        }
    }
}
