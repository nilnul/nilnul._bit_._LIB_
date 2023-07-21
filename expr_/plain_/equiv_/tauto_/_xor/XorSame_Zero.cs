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
	public class XorSameIsZero
	{

		static public ExprI_membered CreateExpr(V x ) { 

			

			return duo.Call.CreateEq(

				
					nilnul.bit.expr.duo.Call.CreateMa(x, x)
					
				,

				
					0
				

			)
			;

		}
	}
}
