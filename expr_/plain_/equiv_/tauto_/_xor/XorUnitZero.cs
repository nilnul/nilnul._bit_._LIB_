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
	public class XorUnitIsZero
	{

		static public ExprI_membered CreateExpr(V x ) { 

			

			return  nilnul.bit.expr.duo.Call.CreateEq(

				
					nilnul.bit.expr.duo.Call.CreateNe(x, false)
					
				,

				
					0
				

			)
			;

		}
	}
}
