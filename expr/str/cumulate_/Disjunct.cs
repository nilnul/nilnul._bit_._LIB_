using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;
using E = nilnul.bit.ExprI_membered;


namespace nilnul.bit.expr.str.op
{
	public class Disjunct
	{
		static public E ToExpr(IEnumerable<E> exprs) {

			if (exprs.Count()==0)
			{
				return expr.no.Call.CreateNil();
			}

			else
			{
				return expr.duo.Call.CreateMa(
					exprs.First()
					,
					ToExpr(exprs.Skip(1))
				);
			}
		}
	}
}
