using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr._vars
{
	public class Visitor : System.Linq.Expressions.ExpressionVisitor
	{
		private expr_.var.Set _vars=new expr_.var.Set();

		public Expression Visit(ExprI_sys expr)
		{
			return Visit(expr.sys.ee.lambda.ee);
		}

		public expr_.var.Set vars
		{
			get { return _vars; }
			set { _vars = value; }
		}
		

		protected override Expression VisitParameter(ParameterExpression node)
		{
			_vars.Add(
				new expr_.Var_sys(
					node
				)  /// var with same par is eq.
			);
			return base.VisitParameter(node);
		}
	}
}
