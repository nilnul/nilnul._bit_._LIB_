using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.sort
{
	/// <see cref="nilnul.bit.var.set.Minterm"/>
	/// <summary>
	/// 
	/// </summary>
	///
	[Obsolete(nameof(bit.expr_.var.set.ballot.IProduct))]
	public class Minterm
	{
		static public bit.expr.simple.str.op.Conjunct.Call Eval(bit.var.set.Assignment assignment) {

			return new bit.expr.simple.str.op.Conjunct.Call(
				assignment.Select(
					x=> 
					x.Value			?
						((bit.expr.stati.VarAsExpr)(x.Key)) as bit.ExprI_membered
						: 
						bit.expr.Call.CreateNeg(x.Key) as bit.ExprI_membered
				)
			)
			
			;
		}


		static public bit.expr.simple.str.op.Conjunct.Call _Eval(IEnumerable<bit.VarI1> vars, IEnumerable<bool> vals) {
			var assignment = new List<bit.ExprI_membered>();

			for (int i = 0; i < vars.Count(); i++)
			{
				assignment.Add(
					vals.ElementAt(i)?((bit.expr.VarAsExpr)(vars.ElementAt(i))) as bit.ExprI_membered
						: 
						bit.expr.Call.CreateNeg(vars.ElementAt(i)) as bit.ExprI_membered
				);
				
			}

			return new bit.expr.simple.str.op.Conjunct.Call(assignment);
		}




	}
}
