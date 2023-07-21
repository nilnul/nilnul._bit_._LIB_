
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;
using E = nilnul.bit.ExprI1;


namespace nilnul.bit.expr.str.aggregate_
{
	public class Conjunct1
	{


		static public E ToExpr(IEnumerable<E> exprs) {

			if (exprs.Count()==0)
			{
				return expr.call_.No.CreateOne();
			}

			else
			{
				return expr.call_.Duo.CreateMi(
					exprs.First()
					,
					ToExpr(exprs.Skip(1))
				);
			}
		}

		static public E ToExpr(params E[] exprs) {

			return ToExpr(exprs as IEnumerable<E>);
		}

	}
}
