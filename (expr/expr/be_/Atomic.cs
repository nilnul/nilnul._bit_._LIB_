using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.be_
{

	/// <summary>
	/// if it's var, not var, no.call.
	/// </summary>
	/// <remarks>
	/// we are considering to change the meaning of this to:
	///		var, or call_.nary, as these two are really atomic or unseparable.
	///	var or nary.
	/// </remarks>
	public class Atomic:BeI
	{
		

		static public bool Eval(ExprI1 expr) {
			return (
				expr is expr_.VarAsExpr
				||
				expr is expr_.call_.No 
				
			);
		}

		public bool be(ExprI1 obj)
		{
			return Eval(obj);
			throw new NotImplementedException();
		}

	}




}
