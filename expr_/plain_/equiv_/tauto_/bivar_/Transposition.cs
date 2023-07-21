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
	/// x->y = !y ->!x
	/// </summary>
	public class Transposition : _ident.BinaryA2
	{
		public override ExprI_membered createPrecedent(Var2 v, Var2 v1)
		{
			return nilnul.bit.expr.duo.Call.CreateImply(v, v1);
			throw new NotImplementedException();
		}

		public override ExprI_membered createSubsequent(Var2 v, Var2 v1)
		{
			return nilnul.bit.expr.duo.Call.CreateImply(
				nilnul.bit.expr.Call.CreateNeg(v1)
				,
				nilnul.bit.expr.Call.CreateNeg(v)
			);
			throw new NotImplementedException();
		}
	}
}
