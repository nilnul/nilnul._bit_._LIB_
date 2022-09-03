using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.Var2;
using E = nilnul.bit.ExprI_membered;

namespace nilnul.bit.expr.infer
{
	public class P__Q_R___P_Q__P_R:_infer.TernaryA
	{

		

		public override E createPrecedent(V v, V v1,V v2)
		{
			return  nilnul.bit.expr.duo.Call.CreateImply(
				v,

				nilnul.bit.expr.duo.Call.CreateImply(v1,v2)
			);
			throw new NotImplementedException();
		}

		public override E createSubsequent(V v, V v1,V v2)
		{
			return nilnul.bit.expr.duo.Call.CreateImply(
				nilnul.bit.expr.duo.Call.CreateImply(v,v1)
				, 
				nilnul.bit.expr.duo.Call.CreateImply(v,v2)
			);

			throw new NotImplementedException();
		}
	}
}
