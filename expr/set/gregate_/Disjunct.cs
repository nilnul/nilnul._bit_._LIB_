using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;
using E = nilnul.bit.ExprI_membered;


namespace nilnul.bit.expr.set.call
{
	public class Disjunct:Call
	{
		public Disjunct():base(bit.set.op.Disjunct.Singleton)
		{
		}

		public Disjunct(nilnul.bit.expr.Set set):base(bit.set.op.Disjunct.Singleton, set)
		{
		}

		public Disjunct(IEnumerable<ExprI_membered> exprs):this( new Set(exprs) )
		{
		}

		public E toExpr()
		{
			return nilnul.bit.expr.str.op.Disjunct.ToExpr(this.arg);
		}
	}
}
