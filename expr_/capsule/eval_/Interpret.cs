using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr
{
	/// <summary>
	/// 
	/// </summary>
	/// 
	[Obsolete(nameof( nilnul.bit.expr_.closed_.calc._EvalX))]
	public class Interpret
	{


		static public bool Eval(nilnul.bit.ExprI_membered expr,  bit.var.set.Assignment assignment_allVars)
		{


			

			nilnul.Assert1.True(
				nilnul.bit.var.set.Eq.Instance.Equals((expr as bit._expr.VarsI).vars, assignment_allVars.vars)	
			);
			




			var result=expr;

			foreach (var item in (expr as bit._expr.VarsI).vars)
			{
				result = expr.substitute(item, (no.Call)assignment_allVars[item] );
			}

			
			return ((result as bit._expr.ReduceI).reduce() as bit.expr.no.Call).eval();
			


			throw new NotImplementedException();
		}

		static public bool _Eval(nilnul.bit.ExprI_membered expr,  IEnumerable<bool> assignment_allVars)
		{




			var vars = (expr as bit._expr.VarsI).vars;


			var result=expr;
			for (int i = 0; i < (expr as bit._expr.VarsI).vars.Count; i++)
			{

			
				result = result.substitute(vars.ElementAt(i), (no.Call)assignment_allVars.ElementAt(i) );
			}

			
			return ((result as bit._expr.ReduceI).reduce() as bit.expr.no.Call).eval();
			


			throw new NotImplementedException();
		}



	}


}
