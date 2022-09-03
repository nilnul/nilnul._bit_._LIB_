using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;

namespace nilnul.bit.expr
{
	[Obsolete()]
	public class Set:nilnul.Set_eqDefault<ExprI_membered,expr.Eq>
	{

		public Set():base()
		{

		}

		public void add(V v) {
			base.add(
				new VarAsExpr(v)
			);
		}

		public Set(IEnumerable<ExprI_membered> exprs):base(exprs)
		{

		}


		//public Set extend() {

		//}

	}
}
