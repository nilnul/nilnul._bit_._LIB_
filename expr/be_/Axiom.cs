using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.be
{
	/// <summary>
	/// the expr, tried with different combinations of assignment of values, is always equal to 1.
	/// </summary>
	public class Axiom
	{

		static public bool Eval(nilnul.bit.ExprI_membered expr){
			///todo assign each value.
			/// 
			var vars=(expr as bit._expr.VarsI).vars;

			//bit.expr.stati.StatiI reduced;

			if (vars.Count==0)
			{
				return ((expr as bit._expr.ReduceI).reduce() as bit.expr.no.Call).eval();
			}

			var firstVar = vars.First();

			
			return Eval( expr.substitute(firstVar, bit.expr.no._zero.Call.Singleton))
				&& Eval(
				expr.substitute(firstVar, bit.expr.no._one.Call.Singleton)
				) ;


			

			throw new NotImplementedException();
		}



	}
}
