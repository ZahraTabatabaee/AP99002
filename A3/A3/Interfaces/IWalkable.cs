namespace A3.Interfaces
{
    public interface IWalkable
    {
        public double SpeedRate { get; set; }
        public string Walk();
    }
}