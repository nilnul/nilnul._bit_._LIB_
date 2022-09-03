using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;

namespace nilnul.bit.expr.ident
{
	/// <summary>
	/// xor is associative.
	/// </summary>
	public class DeMorgan
	{
		static public ExprI_membered CreateOrExpr(V x, V y)
		{
			return nilnul.bit.expr.duo.Call.CreateEq(
				
				nilnul.bit.expr.duo.Call.CreateMa(
						nilnul.bit.expr.Call.CreateNeg(x)
						,
						nilnul.bit.expr.Call.CreateNeg(y)
				)
				,

				
				nilnul.bit.expr.duo.Call.CreateMi(
						nilnul.bit.expr.Call.CreateNeg(x)
						,
						nilnul.bit.expr.Call.CreateNeg(y)
				)

			);
		}

		static public ExprI_membered CreateAndExpr(V x, V y)
		{
			return nilnul.bit.expr.duo.Call.CreateEq(
				
				nilnul.bit.expr.duo.Call.CreateMi(
						nilnul.bit.expr.Call.CreateNeg(x)
						,
						nilnul.bit.expr.Call.CreateNeg(y)
				)
				,

				
				nilnul.bit.expr.duo.Call.CreateMa(
						nilnul.bit.expr.Call.CreateNeg(x)
						,
						nilnul.bit.expr.Call.CreateNeg(y)
				)

			);
		}


	}
}
