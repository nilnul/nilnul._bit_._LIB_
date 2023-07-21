using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;

namespace nilnul.bit.expr
{
	public class Set1:nilnul.obj.Set_eqDefault<ExprI1,expr.Eq1>
	{

		public Set1():base()
		{

		}

		public void add(V v) {
			hashSet.Add(
				new expr_.VarAsExpr(v)
			);
		}

		public void add(ExprI1 v) {
			hashSet.Add(
				(v)
			);
		}


		public Set1(IEnumerable<ExprI1> exprs):base(exprs)
		{

		}


		//public Set extend() {

		//}

	}
}
