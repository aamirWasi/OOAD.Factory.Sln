using System;

namespace OOD.CarB2
{
    public static class CarFactory
    {
        public static Car CreateCar(string carName)
        {
            var carType = Type.GetType("OOD.CarB2."+carName);
            var constractor = carType.GetConstructor(new[] { typeof(string)});
            var car = (Car)constractor.Invoke(new object[] { carName});
            return car;
        }

    }
}
