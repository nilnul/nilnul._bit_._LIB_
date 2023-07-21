using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;
using E = nilnul.bit.ExprI_membered;


namespace nilnul.bit.expr.set.call
{
	public class Conjunct:Call
	{

		public Conjunct():base(bit.set.op.Conjunct.Singleton)
		{

		}

		public Conjunct(nilnul.bit.expr.Set set):base(bit.set.op.Conjunct.Singleton, set)
		{

		}

		public Conjunct(IEnumerable<ExprI_membered> exprs):this( new Set(exprs) )
		{

		}

		public E toExpr() {

			return nilnul.bit.expr.str.op.Conjunct.ToExpr(this.arg);

		}
	}

}
