using System;
using System.IO;

namespace A8.OOCalculator
{
    public class DivideOperator : BinaryOperator
    {
        public DivideOperator(TextReader reader)
        {
            base.LHS = Expression.BuildExpressionTree((StreamReader) reader);
            base.RHS = Expression.BuildExpressionTree((StreamReader) reader);
        }

        public override string OperatorSymbol => "/";

        public override double Evaluate() => base.LHS.Evaluate()/base.RHS.Evaluate();
    }
}