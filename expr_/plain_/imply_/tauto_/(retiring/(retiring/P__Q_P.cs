using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.Var2;
using E = nilnul.bit.ExprI_membered;

namespace nilnul.bit.expr.infer
{
	public class P__Q_P:_infer.BinaryA
	{

		

		public override E createPrecedent(V v, V v1)
		{
			return  new VarAsExpr( v);
			throw new NotImplementedException();
		}

		public override E createSubsequent(V v, V v1)
		{
			return nilnul.bit.expr.duo.Call.CreateImply(v1, v);

			throw new NotImplementedException();
		}
	}
}
