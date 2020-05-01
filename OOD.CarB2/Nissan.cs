using System;

namespace OOD.CarB2
{
    public class Nissan : Car
    {
        public Nissan(string model)
        {
            Model = model;
        }
        public override void Accelarate()
        {
            Console.WriteLine($"{Model}'s started");
        }

        public override void Break()
        {
            Console.WriteLine($"{Model}'s stopped");
        }
    }
}
