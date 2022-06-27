using A3.Interfaces;

namespace A3.Classes.Vehicles
{
    public class Submarine : ISwimable
    {
        public string Model ;
        public double MaxDepthSupported ;
        public double _SpeedRate;
        public Submarine(string model, double maxDepthSupported, double speedRate)
        {
            Model = model ;
            MaxDepthSupported = maxDepthSupported ;
            _SpeedRate = speedRate ;
        }

        public double SpeedRate { get => _SpeedRate; set => _SpeedRate = value; }

        public string Swim()
        {
            return $"{Model} is a {typeof(Submarine).Name} and is swimming in {MaxDepthSupported} meter depth";
        }
    }
}