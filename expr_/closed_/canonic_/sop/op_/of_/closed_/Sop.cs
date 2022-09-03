using nilnul.bit.expr;
using nilnul.bit.var.stati.str.distinct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.vars.minterms.canonical
{
	static public class _TabuleauX
	{

		static public nilnul.bit.expr.simpleProduct.str.op.Sum.Call Eval(ExprI_membered expr) {

			return new expr.simpleProduct.str.op.Sum.Call( 
				expr.GetTruthTable().getInterpretatios().Where(
					interpretation=>interpretation.result
				).Select( 
					interpretation
					=>
					bit.var.set.Minterm.Eval(interpretation.assignment)
				)
			);



		}
	}
}
