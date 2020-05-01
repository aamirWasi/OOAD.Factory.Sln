using System;

namespace OOD.FactoryClass11
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var option = Console.ReadLine();
                var fighter = FighterPlaneFactory.CreatePlane(option);
                fighter.Fly();
                fighter.DropBomb();
                fighter.FireMachineGun(10);
                fighter.FireMissile(3);
                fighter.Land();
                Console.WriteLine();
                Console.WriteLine("Press 'Enter' for menu.");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
