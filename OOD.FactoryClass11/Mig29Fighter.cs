using System;

namespace OOD.FactoryClass11
{
    public class Mig29Fighter : FighterPlane
    {
        public override void DropBomb()
        {
            Console.WriteLine($"{Model}'s dropping bomb");
        }

        public override void FireMachineGun(int count)
        {
            MachineGun -= count;
            Console.WriteLine($"{Model}'s firing {count} machinegun and left {MachineGun}");
        }

        public override void FireMissile(int count)
        {
            Missile -= count;
            Console.WriteLine($"{Model}'s firing {count} missile and left {Missile}");
        }

        public override void Fly()
        {
            Console.WriteLine($"{Model}'s now Flying with\nMachineGun : {MachineGun}\nMissile : {Missile}\nBomb : {Bomb}");
        }

        public override void Land()
        {
            Console.WriteLine($"Now {Model}'s Landing with\nMachineGun : {MachineGun}\nMissile : {Missile}\nBomb : {Bomb}");
        }
    }
}
