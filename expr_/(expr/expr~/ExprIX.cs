using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._expr;
using nilnul._op;
using nilnul.bit._expr;
using nilnul.bit.var;
using nilnul.var;

namespace nilnul.bit
{

	/// <summary>
	/// 
	/// </summary>
	static public class ExprIX

	{
		static public ExprI3 Substitute(this ExprI3 expr, nilnul.bit.VarI1 oldVar, nilnul.bit.VarI1 newVar)
		{
			return expr.substitute(
				oldVar, 
				new expr_.Var1(newVar)
			);
		}

	}






}
