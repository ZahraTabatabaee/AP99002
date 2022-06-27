using System;

namespace E1
{
    public struct IntWithOp : ICalculable<IntWithOp>, IEquatable<IntWithOp>
    {
        private static Random Rnd = new Random(0);

        public IntWithOp(int value)
        {
            Value = value;
        }

        public int Value {get; private set;}

        public IntWithOp PlusIdentity
        {
            get => new IntWithOp(1);
        }

        public IntWithOp NegIdentity
        {
            get => new IntWithOp(-1);
        }

        public IntWithOp AddWith(IntWithOp other)
            => new IntWithOp(this.Value + other.Value);


        public IntWithOp Clone()
            => new IntWithOp(this.Value );

        public bool Equals(IntWithOp other)
        {
            return this.Value == other.Value;
        }

        public void LoadFromStr(string str)
        {
            int x = int.Parse(str);
            this.Value = x ;
        }
        public override string ToString()
            => this.Value.ToString();

        public IntWithOp MultiplyBy(IntWithOp other)
            => new IntWithOp(this.Value * other.Value);

        public void Reset()
        {
            this.Value = 0 ;
        }

        public void RndSet()
        {
            int x = Rnd.Next();
            this.Value = x ; //////point
        }

        public void Set(IntWithOp o)
        {
            this.Value = o.Value;
        }
    }
}
