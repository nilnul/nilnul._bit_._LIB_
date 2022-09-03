using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.tauto
{
	public class Assert : nilnul.AssertI<nilnul.bit.ExprI_membered>
	{
		public void assert(ExprI_membered obj)
		{
			nilnul.bit.expr.Tauto.Assert(obj);
			return;
			throw new NotImplementedException();
		}
	}
}
