using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.vow_.atomic
{
	[Obsolete()]
	public class Ed : nilnul.obj.vow.Ed<nilnul.bit.ExprI1, nilnul.bit.expr.be_.atomic.Vow>
	{
		public Ed(ExprI1 val) : base(val)
		{
		}

		//static public implicit operator ExprI1(Ed ed) { return ed.ed; }

		static public implicit operator Ed(expr_.call_.No no) {
			return new Ed(no);
		}

		static public implicit operator Ed(expr_.VarAsExpr var) {
			return new Ed(var);
		}

	}
}
