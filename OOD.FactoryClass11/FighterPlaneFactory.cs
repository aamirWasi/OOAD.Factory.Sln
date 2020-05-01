using System;

namespace OOD.FactoryClass11
{
    public static class FighterPlaneFactory
    {
        public static FighterPlane CreatePlane(string selection)
        {
            var fighterType = Type.GetType("OOD.FactoryClass11."+selection);
            var constructor = fighterType.GetConstructor(new Type[] { });
            var fighter=(FighterPlane)constructor.Invoke(new object[] { });
            Console.Write("Model Name : ");
            fighter.Model = Console.ReadLine();
            Console.Write("Speed : ");
            fighter.Speed = double.Parse(Console.ReadLine());
            Console.Write("Bomb : ");
            fighter.Bomb = int.Parse(Console.ReadLine());
            Console.Write("Missile : ");
            fighter.Missile = int.Parse(Console.ReadLine());
            Console.Write("MachineGun : ");
            fighter.MachineGun = int.Parse(Console.ReadLine());
            return fighter;
        }
        //FighterPlane fighter = null;
        //public FighterPlane CreatePlane(string selection)
        //{
        //    if (selection == "f16")
        //    {
        //        fighter = new F16Fighter
        //        {
        //            MachineGun = 100,
        //            Missile = 35,
        //            Bomb = 57,
        //            Model = "F-16 Fighter Plane",
        //            Speed = 700
        //        };
        //    }
        //    else if (selection == "mig29")
        //    {
        //        fighter = new Mig29Fighter
        //        {
        //            MachineGun = 120,
        //            Missile = 25,
        //            Bomb = 76,
        //            Model = "Mig-29 Alpha Fighter Plane",
        //            Speed = 800
        //        };
        //    }
        //    return fighter;
        //}
    }
}
