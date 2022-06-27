using static System.Console;

namespace A8.StatePattern
{
    public class AccumulateState : CalculatorState
    {
        public AccumulateState(Calculator calc) : base(calc) 
        {}

        // #7 لطفا
        public override IState EnterEqual()
        {
            ProcessOperator(new StartState(this.Calc),Calc.PendingOperator);
            this.Calc.Display = this.Calc.Accumulation.ToString();
            return new ComputeState(this.Calc);
        }
        public override IState EnterZeroDigit() => EnterNonZeroDigit('0');
        public override IState EnterNonZeroDigit(char c)
        {
            this.Calc.Display += c.ToString();
            return new AccumulateState(this.Calc);
        }

        // #9 لطفا!
        public override IState EnterOperator(char c)
        {
            this.Calc.PendingOperator = c ;
            this.Calc.Accumulation = double.Parse(this.Calc.Display) + this.Calc.Accumulation ;
            return new ComputeState(this.Calc);
        }

        public override IState EnterPoint()
        {
            this.Calc.Display += ".";
            return new PointState(this.Calc);
        }
    }
}