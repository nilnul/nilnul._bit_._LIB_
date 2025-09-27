using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.be
{

	/// <summary>
	/// if it's var, not var, no.call.
	/// </summary>
	/// <see cref=""/>
	/// 
	[Obsolete(nameof(bit.expr_.var.set._ballot.IValve))]
	public class Simple:nilnul.BeI<nilnul.bit.ExprI_membered>
	{
		static public bool IsNegVar(nilnul.bit.expr.Call x) {
			return x.op is bit.op.Not
					&&
					x.arg is VarAsExpr;

		}

		static public bool Eval(nilnul.bit.ExprI_membered expr) {
			return  (
				Atomic.Eval(expr)
				|| 
				(
					expr is nilnul.bit.expr.Call  
					&&
					IsNegVar(
						expr as nilnul.bit.expr.Call
					)
				)
			);
		}

		public bool be(nilnul.bit.ExprI_membered obj)
		{
			return Eval(obj);
			throw new NotImplementedException();
		}

		public class Asserted: nilnul.be.Asserted<nilnul.bit.ExprI_membered,Simple>
		{
			public Asserted(nilnul.bit.ExprI_membered x):base(x)
			{

			}

			

			public Asserted(bit.VarI1 x):this ( new VarAsExpr( x ))
			{

			}




		}
	}




}
