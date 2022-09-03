using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr_.call_;
using s = System.Linq.Expressions;

namespace nilnul.bit.expr_.calc
{
	static public class _EvalX1
	{
		static public bool Eval_assumeCalc(System.Linq.Expressions.Expression _form)
		{
			return nilnul.obj.expr_.typed_.generi_._CalcX._Calc_assumeNoVar<bool>(_form);
			var t= s.Expression.Lambda<Func<bool> >(_form);
			//var t= s.Expression.Lambda<Func<bool> >(typeof(bool) ,_form);
			return t.Compile()();

		}

		public static bool Eval_assumeCalc(ExprI_sys expr)
		{
			return Eval_assumeCalc(expr.sys.ee.lambda);
		}
		public static bool Eval_assumeCalc(Expr_sys expr)
		{
			return Eval_assumeCalc(expr.sys.ee.lambda);
		}

	}


}
