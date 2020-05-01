namespace OOD.CarB2
{
    public abstract class Car
    {
        public string Model { get; set; }
        public double Speed { get; set; }
        public abstract void Accelarate();
        public abstract void Break();
    }
}
