using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.Var2;
using E = nilnul.bit.ExprI1;

namespace nilnul.bit.expr_.call_.duo_.equiv.be_.tauto.vow.ed_
{
	/// <summary>
	/// x->y = !x |y
	/// </summary>
	public class Switcheroo
	{
		static public E CreateExpr(V x,V y)
		{
			return bit.expr.call_.Duo.CreateEq(
					bit.expr.call_.Duo.CreateImply(
						x
						,
						y
					)
					,
					bit.expr.call_.Duo.CreateMa(
						bit.expr.call_.Mono.CreateNeg(x)
						,y
					)
				)
			;
		}

		static public void Vow(V x,V y)
		{
			nilnul.bit.expr.vow_.Tauto.Vow(
				CreateExpr(x,y)
			);
		}
	}
}
