using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.closed_.calc
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


		static public bool Eval(nilnul.bit.ExprI_sys expr, bit.expr_.var.set.Allot assignment_allVars)
		{
			var vars = nilnul.bit.expr._VarsX.Vars(expr);
			nilnul.obj.aver_.True.Aver(
				nilnul.bit.expr_.var.set.Eq.Singleton.Equals(
					vars
				, assignment_allVars.Keys
				)
			);

			var result = expr;

			foreach (var item in vars)
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



	}
}
