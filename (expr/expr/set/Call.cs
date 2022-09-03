using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.set
{
	public class Call:nilnul._call.OpArgA<nilnul.bit.set.OpI,expr.Set>
	{

		public Call(bit.set.OpI op, expr.Set set):base(op,set)
		{

		}

		public Call(bit.set.OpI op):base(op,new Set())
		{

		}


		public Call(bit.set.OpI op, IEnumerable<ExprI_membered> exprs):base(op,new Set(exprs))
		{

		}


		static public Call CreateDisjunct(expr.Set set) {
			return new Call(new nilnul.bit.set.op.Disjunct(), set);
		}

		static public Call CreateConjunct(expr.Set set) {
			return new Call(new nilnul.bit.set.op.Conjunct(), set);
		}
		static public Call CreateConjunct(IEnumerable<bit.ExprI_membered>  exprs) {
			return new Call(new nilnul.bit.set.op.Conjunct(), exprs);
		}


	}
}
