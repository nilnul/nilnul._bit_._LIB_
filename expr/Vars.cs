using nilnul.bit.expr_;
using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr
{
	/// <summary>
	/// </summary>
	/// alias:
	///		parS
	/// 
	static public class _VarsX
	{
		static public nilnul.bit.expr_.var.Set Vars(this nilnul.bit.ExprI_sys expr) {
			var v = new _vars.Visitor();
			v.Visit(expr);
			return v.vars;
		}
		static public nilnul.bit.expr_.var.Set4generi Vars4set(this nilnul.bit.ExprI_generi expr) {
			var v = new _vars.Visitor4generi();
			v.Visit(expr);
			return v.vars;
		}

		public  static obj.expr_.var.SetOfVars VarsAsObjExpr(this ExprI_generi expr)
		{
			return nilnul.obj.expr._VarsX1.Vars(expr);
		}


	}
}
