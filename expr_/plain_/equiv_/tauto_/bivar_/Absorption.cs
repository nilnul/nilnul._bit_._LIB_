using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;

namespace nilnul.bit.expr_.plain_.equiv_.tauto_.bivar_
{
	/// <summary>
	/// x->y = x->x&y
	/// </summary>
	public class Absorption : expr._ident.BinaryA2
	{
		public override ExprI_membered createPrecedent(
			nilnul.bit.Var2 v, nilnul.bit.Var2 v1
		)
		{
			return nilnul.bit.expr.duo.Call.CreateImply(v, v1);
		}

		public override ExprI_membered createSubsequent(bit.Var2 v, bit.Var2 v1)
		{
			return nilnul.bit.expr.duo.Call.CreateImply(
				v
				,
				nilnul.bit.expr.duo.Call.CreateMi(v,v1)
			);
		}
	}
}
