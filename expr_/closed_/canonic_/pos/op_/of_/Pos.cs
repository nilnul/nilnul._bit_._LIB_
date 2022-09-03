using nilnul.bit.var.stati.str.distinct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.cannonic
{
	public class Pos
	{

		static public expr.simpleSum.str.op.Product.Call Eval(nilnul.bit.ExprI_membered expr) {

			return new nilnul.bit.expr.simpleSum.str.op.Product.Call( 
				expr.GetTruthTable().getInterpretatios().Where(
					interpretation=>!interpretation.result
				).Select( 
					interpretation
					=>
					bit.var.set.Maxterm.Eval(interpretation.assignment)
				)
			);



		}
	}
}
