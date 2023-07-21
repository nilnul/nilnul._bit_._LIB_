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
	///
	[Obsolete(nameof(bit.expr_.var.set._sel.IValve))]
	public partial class Simple:nilnul.obj.BeI<StatiI>
	{
		static public bool IsNegVar(mono.Call x) {
			return x.op is bit.mono.op.Not
					&&
					x.arg is VarAsExpr;

		}

		static public bool Eval(StatiI stati) {
			return (
				stati is VarAsExpr 
				||
				stati is no.Call 
				|| 
				(
					stati is mono.Call  
					&&
					IsNegVar(
						stati as mono.Call
					)
				)
			);
		}

		public bool be(StatiI obj)
		{
			return Eval(obj);
			throw new NotImplementedException();
		}
	}




}
