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
	public class XorCommutitive
	{

		static public ExprI_membered CreateExpr( nilnul.bit.VarI1 x , nilnul.bit.VarI1 y) { 

			

			return  nilnul.bit.expr.duo.Call.CreateEq(

				
					nilnul.bit.expr.duo.Call.CreateMa(x, y)
					
				
				,

				
					nilnul.bit.expr.duo.Call.CreateMa(y, x)
				

			)
			;

		}
	}
}
