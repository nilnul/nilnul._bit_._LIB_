using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.ExprI_membered;
using V = nilnul.bit.VarI1;

namespace nilnul.bit.expr.eg
{
	public class P_le_Q__or__P_le_notQ
	{
		static public E Create(V p, V q) {

			return nilnul.bit.expr.duo.Call.CreateMa(
				nilnul.bit.expr.duo.Call.CreateImply(p, q)
				,
				nilnul.bit.expr.duo.Call.CreateImply(
					p
					,
					nilnul.bit.expr.Call.CreateNeg(q)
				)
			);

		}

		static public E Create() {
			return Create(
				new nilnul.bit.Var2()
				,
				new nilnul.bit.Var2()
			);
		}
	}
}
