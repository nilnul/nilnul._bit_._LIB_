
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;
using E = nilnul.bit.ExprI1;


namespace nilnul.bit.expr.accumulate_
{
	public class Conjunct
	{


		static public E Eval(IEnumerable<E> exprs) {

			if (exprs.Count()==0)
			{
				return expr_.call_.No.CreateOne();
			}

			else
			{
				return expr_.call_.Duo.CreateMi(
					exprs.First()
					,
					Eval(exprs.Skip(1))
				);
			}
		}

		static public E Eval(params E[] exprs) {

			return Eval(exprs as IEnumerable<E>);
		}

	}
}
