using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.Var2;
using E = nilnul.bit.ExprI_membered;

namespace nilnul.bit.expr.infer.binary
{
	public class P_n_Q__P:_infer.BinaryA
	{

		

		public override E createPrecedent(V v, V v1)
		{
			return  nilnul.bit.expr.duo.Call.CreateMi(v, v1);
			throw new NotImplementedException();
		}

		public override E createSubsequent(V v, V v1)
		{
			return new VarAsExpr(v);

			throw new NotImplementedException();
		}
	}
}
