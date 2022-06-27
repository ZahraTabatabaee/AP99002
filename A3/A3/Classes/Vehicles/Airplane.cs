using A3.Interfaces;

namespace A3.Classes.Vehicles
{
    public class Airplane : IFlyable
    {
        public string Model;
        public double _SpeedRate;

        public Airplane(double speedRate, string model)
        {
            this.Model = model ;
            this._SpeedRate = speedRate ;
        }

        public double SpeedRate
        {
            get
            {
                return _SpeedRate ;
            }
            set
            {
                _SpeedRate = value ;
            }
        }

        public string Fly()
        {
            // return Model+" with "+_SpeedRate+" spead rate is flying" ;
            return $"{Model} with {_SpeedRate} speed rate is flying";
        }
    }
}