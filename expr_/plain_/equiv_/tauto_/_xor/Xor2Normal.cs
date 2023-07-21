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
	public class Xor2Normal
	{

		static public ExprI_membered CreateExpr(V x, V y)
		{



			return duo.Call.CreateEq(
				nilnul.bit.expr.duo.Call.CreateNe(x, y)
				,
				nilnul.bit.expr.duo.Call.CreateMa(
					nilnul.bit.expr.duo.Call.CreateMi(
							nilnul.bit.expr.Call.CreateNeg(x)
							,

							y
					)
						,
					nilnul.bit.expr.duo.Call.CreateMi(
						x,
						nilnul.bit.expr.Call.CreateNeg(y)
					)
				)
			);
		}
	}
}
