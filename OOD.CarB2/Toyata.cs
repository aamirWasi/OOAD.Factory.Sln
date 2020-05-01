using System;

namespace OOD.CarB2
{
    public class Toyata : Car
    {
        public Toyata(string model)
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
