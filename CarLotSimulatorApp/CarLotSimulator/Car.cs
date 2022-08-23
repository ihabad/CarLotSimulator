using System;

namespace CarLotSimulator
{
    internal class Car
    {

        private bool isDriveable1;

        public Car()
        {

        }

        public Car(
           int Year,
           string Make,
           string Model,
           string EngineNoise,
           string HonkNoise,
           bool IsDriveable
           )
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;

        }

        public Car(int v1, string v2, string v3, string v4, bool v5)
        {
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public static int year { get; set; }
        public static string make { get; }
        public static string model { get; }
        public static string engineNoise { get; set; }
        public static string honkNoise { get; set; }
        public static bool isDriveable { get; }



        public void MakingEngineNoise(string engineNoise)

        {
            Console.WriteLine(engineNoise);
        }

        public void MakingHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
