using nilnul.bit.expr.stati;
using nilnul.bit.expr.stati._stati;
using nilnul.bit.var.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr
{
	[Obsolete(nameof(expr_.closed._ReifyX))]
	static public class _TruthTableX
	{


	


		static public nilnul.bit.var.set.state.interpret.TruthTable GetTruthTable(this bit.ExprI1 expr) {


			var vars = (expr ).vars;
 #if DEBUG
			var vals_enumerated = nilnul.bit.var.set.StateX._EnumerateToStates(vars).ToList();



	//var assignments = nilnul.bit.var.set.Assignment._Enumerate(vars.OrderBy( x=>x, nilnul.obj.var.comparer_.FroNaming.Lazy)).ToList();

#else
			//var assignments = nilnul.bit.var.set.Assignment._Enumerate(vars);

			var vals_enumerated = nilnul.bit.var.set.StateX._EnumerateToStates(vars).ToList();

#endif 




			var results = vals_enumerated.Select(x => new nilnul.bit.var.set.state.Interpret( x ,_InterpretX.Eval(expr, x)));

			var truthTable =new  nilnul.bit.var.set.state.interpret.TruthTable(
				vars,
				results	
			);
			return truthTable;

			
		}


	}
}
