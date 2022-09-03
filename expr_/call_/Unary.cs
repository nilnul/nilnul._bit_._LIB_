using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr.stati._stati;
using nilnul.bit.var.stati;
using nilnul.bit.var.stati.s;
using nilnul.obj.expr.stati._stati;
using nilnul.bit.expr.stati;
using nilnul._expr;
using nilnul.bit.var;
using nilnul.obj._expr_;
using nilnul.bit._expr.untyped.be.vow;
using System.Linq.Expressions;
using nilnul.obj.expr.be_.typed_.generi.vow;

namespace nilnul.bit.expr_.call_
{

	public class Unary3
		:
		nilnul.obj.expr_.call_.UnaryA<
			nilnul.bit.op_.UnaryI1, nilnul.bit.ExprI_generi
		>
		,
		nilnul.bit.ExprI_generi
		,
		bit.expr_.call_.IUnary

	{

		public Unary3(
			bit.op_.UnaryI1 op,
				bit.ExprI_generi x
		)
			: base(op, x)
		{

		}
		public Unary3(			bit.op_.UnaryI1 op,
ParameterExpression x):this(op,

			new nilnul.bit.Expr_generi(x)
		)
		{
		}
		public Unary3(
			bit.op_.UnaryI1 op,

			bit.expr_.Var2 x

			)
			: base(op,
				(x)
			)
		{

		}


	


		public obj._expr.expr0lamda.be_.nonlamda.vow.Ee expr => new obj._expr.expr0lamda.be_.nonlamda.vow.Ee(
(MethodCallExpression)this
)
		;
		public Ee<bool> generi =>	new Ee<bool>(
			this
		);

		

		static public implicit operator System.Linq.Expressions.MethodCallExpression(Unary3 expr)
		{
			return System.Linq.Expressions.Expression.Call(
				Expression.Constant(expr.op)
				,
				expr.op.GetType().GetMethod("op", new[] { typeof(bool) })

				,
				expr.arg.expr.ee

			);
		}
	}

}
