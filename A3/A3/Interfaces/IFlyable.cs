namespace A3.Interfaces
{
    public interface IFlyable
    {
        public double SpeedRate { get; set; }
        public string Fly();
    }
}