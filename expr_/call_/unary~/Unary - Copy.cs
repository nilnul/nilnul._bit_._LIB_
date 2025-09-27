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

namespace nilnul.bit.expr_.call_
{

	[Obsolete()]
	public class Unary_sys
		:
		nilnul.obj.expr_.call_.UnaryA<
			nilnul.bit.op_.UnaryI1, nilnul.bit.ExprI_sys
		>
		,
		nilnul.bit.ExprI_sys
		,
		bit.expr_.call_.IUnary

	{







		public Unary_sys(
			bit.op_.UnaryI1 op,
				bit.ExprI_sys x
		)
			: base(op, x)
		{

		}
		public Unary_sys(
			bit.op_.UnaryI1 op,

			bit.expr_.Var_sys x

			)
			: base(op,
				(x)
			)
		{

		}


		public Ee sys => new Ee(
	(MethodCallExpression)this
);

		//public Set2 vars => throw new NotImplementedException();

		//public ExprI3 substitute(VarI1 var, ExprI3 expr)
		//{
		//	throw new NotImplementedException();
		//}

		static public implicit operator System.Linq.Expressions.MethodCallExpression(Unary_sys expr)
		{
			return System.Linq.Expressions.Expression.Call(
				Expression.Constant(expr.op)
				,
				expr.op.GetType().GetMethod("op", new[] { typeof(bool) })

				,
				expr.arg.sys.ee.lambda.ee

			);
		}
	}

}
