using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;

namespace nilnul.bit.expr.ident
{
	/// <summary>
	/// </summary>
	public class AnyXorOne
	{

		static public ExprI_membered CreateExpr(V x ) { 

			

			return  nilnul.bit.expr.duo.Call.CreateEq(

				
					nilnul.bit.expr.duo.Call.CreateNe(x, 1)
					
				,

				
					nilnul.bit.expr.Call.CreateNeg(x)
				

			)
			;

		}
	}
}
