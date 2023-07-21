using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr._vars
{
	public class Visitor4generi : System.Linq.Expressions.ExpressionVisitor
	{
		private expr_.var.Set4generi _vars=new expr_.var.Set4generi();

		public Expression Visit(ExprI_generi expr)
		{
			return Visit(expr.generi.ee.expr.ee);
		}

		public expr_.var.Set4generi vars
		{
			get { return _vars; }
			set { _vars = value; }
		}
		

		protected override Expression VisitParameter(ParameterExpression node)
		{
			_vars.Add(
				new expr_.Var2(
					node
				)  /// var with same par is eq.
			);
			return base.VisitParameter(node);
		}
	}
}
