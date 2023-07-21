using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr_.call_;
using s = System.Linq.Expressions;

namespace nilnul.bit.expr_.nonvariate
{
	static public class _EvalX
	{
		static public bool _Eval_0nonvariate(System.Linq.Expressions.Expression _form)
		{
			return nilnul.obj.expr_.typed_.generi_._CalcX._Calc_assumeNoVar<bool>(_form);

			//var t= s.Expression.Lambda<Func<bool> >(_form);
			////var t= s.Expression.Lambda<Func<bool> >(typeof(bool) ,_form);
			//return t.Compile()();

		}

		public static bool _Eval_0nonvariate(ExprI_sys expr)
		{
			return _Eval_0nonvariate(expr.sys.ee.lambda);
		}
		public static bool _Eval_0nonvariate(Expr_sys expr)
		{
			return _Eval_0nonvariate(expr.sys.ee.lambda);
		}

		public static bool _Eval_0nonvariate(ExprI_generi result)
		{
			return _Eval_0nonvariate(result.expr.ee);

		}
	}


}
