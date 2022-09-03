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
	public class XorAssociative
	{

		static public ExprI_membered CreateExpr( nilnul.bit.VarI1 x , nilnul.bit.VarI1 y, nilnul.bit.VarI1 z) { 

			

			return  nilnul.bit.expr.duo.Call.CreateEq(

				bit.expr.duo.Call.CreateNe(
					nilnul.bit.expr.duo.Call.CreateMa(x, y)
					,
						 z
				)
				,

				nilnul.bit.expr.duo.Call.CreateNe(
					x
				,
					nilnul.bit.expr.duo.Call.CreateMa(y, z)
				)

			)
			;

		}
	}
}
