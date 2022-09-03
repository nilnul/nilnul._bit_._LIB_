using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.Var2;
using E = nilnul.bit.ExprI_membered;

namespace nilnul.bit.expr.tauto.infer
{
	public class P_Q__P___Q
	{

		static public E CreateExpr(V x, V y)
		{




			return bit.expr.duo.Call.CreateImply(
					bit.expr.duo.Call.CreateMi(
						x
						,
						bit.expr.duo.Call.CreateImply(
							x
							,
							y
						)
					)
					,
					y
				)

			;

		}


		static public void Assert(V x, V y)
		{
			nilnul.bit.expr.Tauto.Assert(

				CreateExpr(x, y)

			);

		}



	}
}
