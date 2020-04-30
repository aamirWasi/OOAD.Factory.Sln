using System;

namespace OOD.FactoryClass11
{
    class Program
    {
        static void Main(string[] args)
        {
            var fighterPlane = new FighterPlaneFactory();
            var fighter = fighterPlane.CreatePlane("f16");
            fighter.Fly();
            fighter.DropBomb();
            fighter.FireMachineGun(10);
            fighter.FireMissile(3);
            fighter.Land();
        }
    }
}
