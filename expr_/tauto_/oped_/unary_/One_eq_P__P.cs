using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;


namespace nilnul.bit.expr.ident.unary
{
	public class One_eq_P__P : _ident.UnaryA1
	{


		public One_eq_P__P(V v):base(v)
		{

		}

		public One_eq_P__P()
		{

		}

		public override ExprI_membered createPrecedent(V v)
		{
			return nilnul.bit.expr.duo.Call.CreateEq(
				1, v
			);



			throw new NotImplementedException();
		}

		public override ExprI_membered createSubsequent(V v)
		{

			return new VarAsExpr(v);

			throw new NotImplementedException();
		}
	}
}
