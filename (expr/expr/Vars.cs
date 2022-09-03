using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr
{
	static public class _VarsX
	{
		static public nilnul.bit.expr_.var.Set Vars(this nilnul.bit.ExprI_sys expr) {
			var v = new _vars.Visitor();
			v.Visit(expr);
			return v.vars;
		}
	}
}
