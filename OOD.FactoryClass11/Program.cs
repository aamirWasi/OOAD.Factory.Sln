using System;

namespace OOD.FactoryClass11
{
    public class FighterPlaneFactory
    {
        FighterPlane fighter = null;
        public FighterPlane CreatePlane(string selection)
        {
            if (selection == "f16")
            {
                fighter = new F16Fighter
                {
                    MachineGun = 100,
                    Missile = 35,
                    Bomb = 57,
                    Model = "F-16 Fighter Plane",
                    Speed = 700
                };
            }
            else if (selection == "mig29")
            {
                fighter = new Mig29Fighter
                {
                    MachineGun = 120,
                    Missile = 25,
                    Bomb = 76,
                    Model = "Mig-29 Alpha Fighter Plane",
                    Speed = 800
                };
            }
            return fighter;
        }
    }
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
