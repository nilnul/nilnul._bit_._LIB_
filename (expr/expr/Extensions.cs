using nilnul.bit._expr.untyped.be.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using nilnul.obj.expr_.typed_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr
{



	static public class _ExtensionsX
	{
		static public ExprO ToOperand(this ExprI_generi x) {
			return new ExprO(x);
		}
	}
}
