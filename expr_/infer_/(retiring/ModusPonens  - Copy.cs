using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.Var2;
using E = nilnul.bit.ExprI1;

namespace nilnul.bit.expr_.tauto_.infer_
{
	public class ModusPonens
	{

		static public E CreateExpr(V x, V y)
		{

			return bit.expr.call_.Duo.CreateImply(
					bit.expr.call_.Duo.CreateMi(
						x
						,
						bit.expr.call_.Duo.CreateImply(
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


		static public void Vow(V x, V y)
		{
			nilnul.bit.expr.vow_.Tauto.Vow(

				CreateExpr(x, y)

			);

		}



	}
}
