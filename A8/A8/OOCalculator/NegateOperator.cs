using System;
using System.IO;

namespace A8.OOCalculator
{
    public class NegateOperator : UnaryOperator
    {
        public NegateOperator(TextReader reader)
        {
            base.Operand = Expression.BuildExpressionTree((StreamReader) reader);
        }

        public override string OperatorSymbol => "-";

        public override double Evaluate() => -1*base.Operand.Evaluate(); 
    }
}