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
	/// <summary>
	/// for <see cref="bit.expr_.stati"/> <see cref="bit.ExprI_membered"/>
	/// </summary>
	[Obsolete(nameof(expr_.closed._ReifyX))]
	static public class TruthTableX
	{

		static public TruthTable GetTruthTable(this bit.ExprI_membered expr) {

			var vars = (expr as bit._expr.VarsI).vars;
 #if DEBUG
			var assignments = nilnul.bit.var.set.Assignment._Enumerate(vars).ToList();
	//var assignments = nilnul.bit.var.set.Assignment._Enumerate(vars.OrderBy( x=>x, nilnul.obj.var.comparer_.FroNaming.Lazy)).ToList();

#else
			var assignments = nilnul.bit.var.set.Assignment._Enumerate(vars);


#endif 




			var results = assignments.Select(x => Interpret._Eval(expr, x));

			var truthTable = TruthTable.Create(
				vars,
				results	
			);
			return truthTable;

			
		}

	



	}
}
