using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.stati
{
	/// <summary>
	/// 
	/// </summary>
	public class Interpret
	{


		static public bool Eval(nilnul.bit.expr.stati.StatiI expr,  bit.var.stati.set.Assignment assignment_allVars)
		{


			

			nilnul.Assert1.True(
				nilnul.bit.var.stati.set.Eq.Instance.Equals((expr as bit.expr.stati._stati.VarsI).vars, assignment_allVars.vars)	
			);
			




			StatiI result=expr;

			foreach (var item in (expr as bit.expr.stati._stati.VarsI).vars)
			{
				result = expr.substitute(item, (no.Call)assignment_allVars[item] );
			}

			
			return ((result as bit.expr.stati._stati.ReduceI).reduce() as bit.expr.stati.no.Call).eval();
			


			//throw new NotImplementedException();
		}

		static public bool _Eval(nilnul.bit.expr.stati.StatiI expr,  IEnumerable<bool> assignment_allVars)
		{




			var vars = (expr as bit.expr.stati._stati.VarsI).vars;


			StatiI result=expr;
			for (int i = 0; i < (expr as bit.expr.stati._stati.VarsI).vars.Count; i++)
			{

			
				result = result.substitute(vars.ElementAt(i), (no.Call)assignment_allVars.ElementAt(i) );
			}

			
			return ((result as bit.expr.stati._stati.ReduceI).reduce() as bit.expr.stati.no.Call).eval();
			


			throw new NotImplementedException();
		}



	}


}
