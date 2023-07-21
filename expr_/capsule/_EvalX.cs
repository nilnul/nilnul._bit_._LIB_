using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.ExprI_generi;

namespace nilnul.bit.expr_.capsule
{
	/// <summary>
	/// to var.sortie
	/// </summary>
	static public class _EvalX
	{
		static public bool Eval(nilnul.bit.Expr_sys expr, bit.expr_.var.set.Allot assignment_allVars)
		{
			nilnul.obj.aver_.True.Aver(
				nilnul.bit.expr_.var.set.Eq.Singleton.Equals(
					(expr).vars
				, assignment_allVars.Keys
				)
			);

			var result = expr;

			foreach (var item in (expr).vars)
			{
				result = nilnul.bit.expr.var.SubstituteX.Substitute(
					result,
					item,
					 assignment_allVars[item]
				);
			}

			return nilnul.bit.expr_.calc._EvalX1.Eval_assumeCalc(result);
			//throw new NotImplementedException();
		}


		static public bool Eval(E expr, bit.expr_.var.set.Sel assignment_allVars)
		{
			var vars = nilnul.bit.expr._VarsX.Vars4set(expr);
			if (!nilnul.bit.expr_.var.set.Eq.Unison.Equals(
					vars
				, assignment_allVars.Keys
				))
			{
				throw new ArgumentException("the vars for assignment donot conform with those of the expr; " );
			}

			var result = expr;

			foreach (var item in vars)
			{
				result = nilnul.bit.expr_.capsule.var._SubstituteX.Substitute(
					result,
					item,
					 assignment_allVars[item]
				);
			}

			return nilnul.bit.expr_.nonvariate._EvalX._Eval_0nonvariate(result);
			//throw new NotImplementedException();
		}



	}
}
