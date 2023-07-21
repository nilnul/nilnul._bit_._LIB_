using nilnul.bit._expr.untyped.be.vow;
using nilnul.bit.op_.binary_;
using nilnul.obj.expr.be_.typed_.generi.vow;
using nilnul.obj.expr_.typed_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_
{
	public class Binary_generi
: nilnul.obj.expr_.call_.BinaryA<
	nilnul.bit.op_.BinaryI1
	,
	nilnul.bit.ExprI_generi
	,
	nilnul.bit.ExprI_generi

	>
		,
		bit.ExprI_generi
	{
		public Binary_generi(op_.BinaryI1 op, ExprI_generi arg, ExprI_generi arg1) : base(op, arg, arg1)
		{
		}

		public Binary_generi(
			op_.BinaryI1 op
			
			, ParameterExpression x
			,
			ConstantExpression constantExpression
		):this(
			op
			,
			new bit.Expr_generi(
				x
			)
			,
			new bit.Expr_generi(
				constantExpression
			)
		)
		{
		}

		public Ee<bool> generi =>new Ee<bool>(
			new nilnul.obj.Expr4(
			(MethodCallExpression)this
			)
		); 

		public obj._expr.expr0lamda.be_.nonlamda.vow.Ee expr =>generi.ee.expr;

		static public  implicit  operator System.Linq.Expressions.MethodCallExpression (Binary_generi expr){
			return System.Linq.Expressions.Expression.Call(
				Expression.Constant(
expr.op),
				expr.op.GetType().GetMethod("op", new[] { typeof(bool),typeof(bool) })

				,
				expr.arg.expr.ee
				,
				expr.arg1.expr.ee
			);
		}
	}
}
