namespace OOD.FactoryClass11
{
    public abstract class FighterPlane
    {
        public double Speed { get; set; }
        public string Model { get; set; }
        public int Bomb { get; set; }
        public int MachineGun { get; set; }
        public int Missile { get; set; }
        public abstract void FireMissile(int count);
        public abstract void FireMachineGun(int count);
        public abstract void DropBomb();
        public abstract void Fly();
        public abstract void Land();
    }
}
