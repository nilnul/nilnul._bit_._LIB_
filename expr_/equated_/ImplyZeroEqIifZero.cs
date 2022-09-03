using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.Var2;
using E = nilnul.bit.ExprI1;


namespace nilnul.bit.expr_.call_.duo_.equiv.be_.tauto.vow.ed_
{
	public class ImplyZeroEqIifZero
	{


		static public E CreateExpr(V a)
		{
			return bit.expr_.call_.Duo.CreateEq(
				bit.expr_.call_.Duo.CreateImply(
					a
					,
					bit.expr_.call_.No.CreateNil()
				)
				,
				bit.expr_.call_.Duo.CreateEq(
					a
					,
					bit.expr_.call_.No.CreateNil()
				)
			);
		}


	}
}
