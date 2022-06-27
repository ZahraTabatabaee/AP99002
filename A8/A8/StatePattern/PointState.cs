namespace A8.StatePattern
{
    /// <summary>
    /// این وضعیت نشان دهنده حالتی است که نقطه زده شده
    /// این وضعیت شبیه وضعیت
    /// Accumulate
    /// است
    /// تنها فرقش این است که نقطه جدیدی نمی شود زد.
    /// تغییرات لازم را برای این کار بدهید.
    /// </summary>
    public class PointState : AccumulateState
    {
        public PointState(Calculator calc) : base(calc) { }

        //#1 لطفا!
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
            return new PointState(this.Calc);
        }
        public override IState EnterOperator(char c)
        {
            this.Calc.PendingOperator = c ;
            this.Calc.Accumulation = double.Parse(this.Calc.Display) + this.Calc.Accumulation ;
            return new ComputeState(this.Calc);
        }
        public override IState EnterPoint()
        {
            // this.Calc.Display = "0.";
            return new PointState(this.Calc);
        }
    }
}