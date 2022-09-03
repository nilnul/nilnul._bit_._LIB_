using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V = nilnul.bit.VarI1;


namespace nilnul.bit.expr.ident
{
	public partial class XMaxXEqX
	{
		static public ExprI_membered CreateExpr(V x)
		{
			return nilnul.bit.expr.duo.Eq.Call(
						nilnul.bit.expr.duo.Max.Call(x ,x)
						,
						x
			);
		}

	}
}
