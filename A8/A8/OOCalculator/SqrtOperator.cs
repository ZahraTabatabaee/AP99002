using System;
using System.IO;

namespace A8.OOCalculator
{
    public class SqrtOperator : UnaryOperator
    {
        public SqrtOperator(TextReader reader)
        {
            base.Operand = Expression.BuildExpressionTree((StreamReader) reader);
        }

        public override string OperatorSymbol => "Sqrt";

        public override double Evaluate() => Math.Sqrt(base.Operand.Evaluate());
    }
}