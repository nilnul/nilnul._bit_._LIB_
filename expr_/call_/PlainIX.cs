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
using E = nilnul.bit.expr_.PlainI;

namespace nilnul.bit.expr_
{

	/// <summary>
	/// 
	/// </summary>
	static public class PlainIX

	{
		static public E Substitute(this E expr, nilnul.bit.VarI1 oldVar, nilnul.bit.VarI1 newVar)
		{
			return expr.substitute(
				oldVar, 
				new expr_.plain_.Var(newVar)
			);
		}

	}






}
