
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;
using E = nilnul.bit.ExprI_membered;


namespace nilnul.bit.expr.str.aggregate_
{
	[Obsolete()]
	public class Conjunct
	{


		static public E ToExpr(IEnumerable<E> exprs) {

			if (exprs.Count()==0)
			{
				return expr.no.Call.CreateOne();
			}

			else
			{
				return expr.duo.Call.CreateMi(
					exprs.First()
					,
					ToExpr(exprs.Skip(1))
				);
			}
		}

		static public E ToExpr(params E[] exprs) {

			if (exprs.Count()==0)
			{
				return expr.no.Call.CreateOne();
			}

			else
			{
				return expr.duo.Call.CreateMi(
					exprs.First()
					,
					ToExpr(exprs.Skip(1))
				);
			}
		}

	}
}
