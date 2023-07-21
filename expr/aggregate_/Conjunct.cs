using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;
using E = nilnul.bit.ExprI1;


namespace nilnul.bit.expr.aggregate_
{
	public class Conjunct
	{
		static public E Eval( nilnul.bit.expr.Set1 set )
		{

			return nilnul.bit.expr.accumulate_.Conjunct.Eval(set.hashSet);

		}

		static public E Eval(params nilnul.bit.ExprI1[] elements )
		{

			return Eval(
				new Set1(elements)
			);

		}

	}
}
