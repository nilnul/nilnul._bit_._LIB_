using nilnul.bit.expr_;
using nilnul.bit.expr_.call_.binary_;
using nilnul.bit.expr_.call_.nary_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.var
{


	/// <summary>
	/// <see cref="expr.op_.unary_.ISubstitute"/>
	/// </summary>
	///
	[Obsolete(nameof(expr_.capsule.var._SubstituteX))]
	static public class SubstituteX
	{

		static public bit.Expr_sys Substitute(this bit.ExprI_sys x, bit.expr_.Var_sys var, bit.ExprI_sys y) {

			return new Expr_sys( new obj._expr.untyped.var._substitute.lambda.Visitor(var, y.sys.ee.lambda).Visit(x.sys.ee.lambda) );
		}

		static public bit.Expr_sys Substitute(this bit.Expr_sys x, bit.expr_.Var_sys var, bit.Expr_sys y) {

			return Substitute(x,var, (bit.ExprI_sys)y);
		}

		public static bit.Expr_sys Substitute(Expr_sys expr, Var_sys firstVar, Expression expression)
		{
			return Substitute(
				expr,firstVar,new Expr_sys(expression)
			);
		}
		public static bit.Expr_sys Substitute(Expr_sys expr, Var_sys firstVar, bool expression)
		{
			return Substitute(
				expr,firstVar, new expr_.call_.Nary_sys(expression)
			);
		}


		public static bit.Expr_sys Substitute(ExprI_sys expr, Var_sys firstVar, bool expression)
		{
			return Substitute(
				expr,firstVar, new expr_.call_.Nary_sys(expression)
			);
		}

		static public bit.Expr_generi Substitute(this bit.ExprI_generi x, bit.expr_.Var2 var, bit.ExprI_generi y)
		{

			return new Expr_generi(
				 obj.expr.var._SubstituteX.Substitute(x,var,y)
				
			);
		}

		static public bit.Expr_generi Substitute(this bit.ExprI_generi x, obj.expr_.typed_.generi_.VarI<bool> var, bit.ExprI_generi y)
		{

			return new Expr_generi(
				 obj.expr.var._SubstituteX.Substitute(x,var,y)
				
			);
		}

		public static Closed Substitute(Closed expr, obj.expr_.typed_.generi_.Var<bool> firstVar, Closed singleton)
		{
			return new Closed(

				 obj.expr.var._SubstituteX.Substitute(expr,firstVar,singleton)
			);

		}

		public static Closed Substitute(ClosedI expr, obj.expr_.typed_.generi_.VarI<bool> firstVar, ClosedI singleton)
		{

			return new Closed(

				 obj.expr.var._SubstituteX.Substitute(expr, firstVar, singleton)
			);

		}

	
	}
}
