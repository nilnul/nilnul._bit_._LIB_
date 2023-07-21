using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.stati.be
{
	/// <summary>
	/// the expr, tried with different combinations of assignment of values, is always equal to 1.
	/// </summary>
	///

	[Obsolete(nameof(bit.expr_.var.set._sel.IValve))]
	public class Axiom
	{

		static public bool Eval(nilnul.bit.expr.stati.StatiI expr){
			///todo assign each value.
			/// 
			var vars=(expr as bit.expr.stati._stati.VarsI ).vars;

			//bit.expr.stati.StatiI reduced;

			if (vars.Count==0)
			{
				return ((expr as bit.expr.stati._stati.ReduceI).reduce() as bit.expr.stati.no.Call).eval();
			}

			var firstVar = vars.First();

			
			return Eval( expr.substitute(firstVar, bit.expr.stati.no._zero.Call.Singleton))
				&& Eval(
				expr.substitute(firstVar, bit.expr.stati.no._one.Call.Singleton)
				) ;


			

			throw new NotImplementedException();
		}



	}
}
