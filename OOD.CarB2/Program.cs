using System;

namespace OOD.CarB2
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var option = Console.ReadLine();
                var car = CarFactory.CreateCar(option);
                StartGame(car);
            }
        }

        private static void StartGame(Car car)
        {
            car.Accelarate();
        }
    }
}
