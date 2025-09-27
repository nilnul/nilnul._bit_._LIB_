using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.sort
{
	public class Maxterm
	{
		static public bit.expr.stati.simple.str.op.Disjunct.Call Eval(bit.var.toset.Assignment assignment)
		{

			return new bit.expr.stati.simple.str.op.Disjunct.Call(
				assignment.Select(
					x =>
					x.val ?
						bit.expr.stati.mono.Call.CreateNeg(x.var) as bit.expr.stati.StatiI
						:
						((bit.expr.stati.VarAsExpr)(x.var)) as bit.expr.stati.StatiI

				)
			);
		}
		static public bit.expr.stati.simple.str.op.Disjunct.Call _Eval(IEnumerable<bit.var.stati.Stati> vars, IEnumerable<bool> vals)
		{
			var assignment = new List<bit.expr.stati.StatiI>();

			for (int i = 0; i < vars.Count(); i++)
			{
				assignment.Add(
					vals.ElementAt(i) ?
						bit.expr.stati.mono.Call.CreateNeg(vars.ElementAt(i)) as bit.expr.stati.StatiI
						:



					((bit.expr.stati.VarAsExpr)(vars.ElementAt(i))) as bit.expr.stati.StatiI

				);

			}

			return new bit.expr.stati.simple.str.op.Disjunct.Call(assignment);
		}


	}
}
