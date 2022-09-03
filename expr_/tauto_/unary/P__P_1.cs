using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;


namespace nilnul.bit.expr.ident.unary
{
	public class P__P_1 : _ident.UnaryA1
	{


		public P__P_1(V v):base(v)
		{

		}

		public P__P_1()
		{

		}

		public override ExprI_membered createPrecedent(V v)
		{
			return new VarAsExpr(v);

			throw new NotImplementedException();
		}

		public override ExprI_membered createSubsequent(V v)
		{
			return nilnul.bit.expr.duo.Call.CreateEq(
				v,1
			);
			throw new NotImplementedException();
		}
	}
}
