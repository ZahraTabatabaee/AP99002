using System;
using System.IO;

namespace A8.OOCalculator
{
    public class SquareOperator : UnaryOperator
    {
        public SquareOperator(TextReader reader)
        {
            base.Operand = Expression.BuildExpressionTree((StreamReader) reader);
        }

        public override string OperatorSymbol => "Square";

        public override double Evaluate() => base.Operand.Evaluate()*base.Operand.Evaluate();

    }
}