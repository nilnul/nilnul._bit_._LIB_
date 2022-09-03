using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.Var2;
using E = nilnul.bit.ExprI_membered;

namespace nilnul.bit.expr.infer
{
	public class P__Q_n_P__notQ___notP:_infer.BinaryA
	{
		public override E createPrecedent(V v, V v1)
		{
			return  nilnul.bit.expr.duo.Call.CreateMi(
				nilnul.bit.expr.duo.Call.CreateImply(v, v1)
				,

				nilnul.bit.expr.duo.Call.CreateImply(
					v
					,
					nilnul.bit.expr.Call.CreateNeg(v1)
				)
			);
			throw new NotImplementedException();
		}

		public override E createSubsequent(V v, V v1)
		{
			return nilnul.bit.expr.Call.CreateNeg(
				
				v
			);
			throw new NotImplementedException();
		}
	}
}
