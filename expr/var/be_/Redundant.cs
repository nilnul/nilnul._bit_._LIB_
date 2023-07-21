using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.var.be_
{
	/// <summary>
	/// if the var's val change would have no effect.
	/// eg:
	///		for:  x &(y | !y) ,  y is redundant.
	/// </summary>
	static public class _RedundantX
	{
		static public bool Be(nilnul.bit.ExprI2 expr, nilnul.bit.VarI1 var)
		{
			return	nilnul.bit.expr.eq_.Equiv1.Singleton.Equals(
				expr.substitute(var, expr_.call_.nulary_.One.Singleton)
				 ,
				expr.substitute(var, expr_.call_.nulary_.Nil.Singleton)
			);
		}

	}
	/// <summary>
	/// 
	/// </summary>
	class Redundant
	{
	}
}
