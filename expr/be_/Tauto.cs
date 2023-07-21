using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.stati.be
{
	/// <summary>
	/// if it's var, not var, no.call.
	/// </summary>
	public class Tauto
	{
		static public bool Eval(nilnul.bit.expr.stati.StatiI expr)
		{
			///todo assign each value.
			/// 
			var vars = (expr as bit.expr.stati._stati.VarsI).vars;

			//bit.expr.stati.StatiI reduced;

			if (vars.Count == 0)
			{
				return ((expr as bit.expr.stati._stati.ReduceI).reduce() as bit.expr.stati.no.Call).eval();
			}

			var firstVar = vars.First();


			return Eval(expr.substitute(firstVar, bit.expr.stati.no._zero.Call.Singleton))
				&& Eval(
				expr.substitute(firstVar, bit.expr.stati.no._one.Call.Singleton)
				);




			throw new NotImplementedException();
		}

	}


}
