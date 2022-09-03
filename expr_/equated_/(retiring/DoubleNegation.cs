using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.Var2;
using E = nilnul.bit.ExprI1;

namespace nilnul.bit.expr_.tauto_.equiv_
{
	[Obsolete(nameof(nilnul.bit.expr_.call_.duo_.equiv.be_.tauto.vow.ed_.DoubleNegation))]
	public class DoubleNegation
	{
		static public E CreateExpr(V x)
		{
			return bit.expr.call_.Duo.CreateEq(
					x
					,
					bit.expr.call_.Mono.CreateNeg(
						bit.expr.call_.Mono.CreateNeg(x)
						
					)
				)
			;
		}

		static public void Vow(V x)
		{
			nilnul.bit.expr.vow_.Tauto.Vow(
				CreateExpr(x)
			);
		}
	}
}
