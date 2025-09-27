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
	/// 
	[Obsolete(nameof(be_))]
	public class Atomic:nilnul.BeI<nilnul.bit.ExprI_membered>
	{
		

		static public bool Eval(nilnul.bit.ExprI_membered stati) {
			return (
				stati is VarAsExpr 
				||
				stati is no.Call 
				
			);
		}

		public bool be(nilnul.bit.ExprI_membered obj)
		{
			return Eval(obj);
			throw new NotImplementedException();
		}

		public class Asserted: nilnul.Asserted<nilnul.bit.ExprI_membered,Atomic>
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
