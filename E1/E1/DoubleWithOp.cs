using System;

namespace E1
{
    public struct DoubleWithOp :
        ICalculable<DoubleWithOp>, IEquatable<DoubleWithOp>
    {
        public DoubleWithOp(double value)
        {
            Value = value;
        }
        private static Random Rnd = new Random(0);
        public double Value {get; private set;}
        public DoubleWithOp PlusIdentity
        {
            get => new DoubleWithOp(1);
        }

        public DoubleWithOp NegIdentity
        {
            get => new DoubleWithOp(-1);
        }

        public DoubleWithOp AddWith(DoubleWithOp other)
            => new DoubleWithOp(this.Value + other.Value);

        public DoubleWithOp Clone()
            => new DoubleWithOp(this.Value);

        public bool Equals(DoubleWithOp other)
        {
            return this.Value == other.Value;
        }

        public void LoadFromStr(string str)
        {
            double x = double.Parse(str);
            this.Value = x ;
        }
        public override string ToString()
            => this.Value.ToString();
        public DoubleWithOp MultiplyBy(DoubleWithOp other)
            => new DoubleWithOp(this.Value * other.Value);

        public void Reset()
        {
            this.Value = 0 ;
        }

        public void RndSet()
        {
            double x = Rnd.Next();
            this.Value = x ; //////point
        }

        public void Set(DoubleWithOp o)
        {
            this.Value = o.Value;
        }
    }
}
