using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.Var2;
using E = nilnul.bit.ExprI1;


namespace nilnul.bit.expr_.call_.duo_.imply.be_.tauto.vow.ed_
{
	/// <summary>
	/// (a & !b -> 0)  => (a->b)
	/// </summary>
	public class Contradiction
	{
		static public E CreateExpr(V a, V b)
		{
			return nilnul.bit.expr_.call_.Duo.CreateImply(
				 nilnul.bit.expr_.call_.Duo.CreateImply(
					nilnul.bit.expr_.call_.Duo.CreateAnd(
						a
						,
						nilnul.bit.expr_.call_.Mono.CreateNeg(b)
					)
					,
					nilnul.bit.expr_.call_.No.CreateNil()
					 
				)
				,
				 nilnul.bit.expr_.call_.Duo.CreateImply(
					a
					,
					b
					 
				)

			);
		}
		static public void Vow(V a, V b) {
			nilnul.bit.expr.be_.tauto.Vow.Eval(CreateExpr(a,b));
		}

		static public void Vow() {
			Vow( new nilnul.bit.Var2(), new nilnul.bit.Var2() );
		}
	}
}
