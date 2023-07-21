using nilnul.bit._expr.untyped.be.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_
{
	public class Binary_sys
: nilnul.obj.expr_.call_.BinaryA<
	nilnul.bit.op_.BinaryI1
	,
	nilnul.bit.ExprI_sys
	,
	nilnul.bit.ExprI_sys

	>
		,
		ExprI_sys
	{
		public Binary_sys(op_.BinaryI1 op, Expr_sys arg, Expr_sys arg1) : base(op, arg, arg1)
		{
		}

		public Binary_sys(op_.BinaryI1 op, ExprI_sys arg, ExprI_sys arg1) : base(op, arg, arg1)
		{
		}

		public Ee sys => new Ee(
			(MethodCallExpression)this
		);

		static public  implicit  operator System.Linq.Expressions.MethodCallExpression (Binary_sys expr){
			return System.Linq.Expressions.Expression.Call(
				Expression.Constant(
expr.op),
				expr.op.GetType().GetMethod("op", new[] { typeof(bool),typeof(bool) })

				,
				expr.arg.sys.ee.lambda.ee
				,
				expr.arg1.sys.ee.lambda.ee
			);
		}
	}
}
