using nilnul.bit.expr.stati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;


namespace nilnul.bit.expr.duo
{
	[Obsolete(nameof(nilnul.bit.expr.call_.Duo))]
	public class Eq
	{
		static public ExprI_membered Call(bit.VarI1 x, bit.VarI1 y) {

			return new _eq.Call(x, y);

		}



		static public ExprI_membered Call(bit.ExprI_membered x, bit.ExprI_membered y) {

			return new _eq.Call(x, y);

		}


		static public ExprI_membered Call(bit.ExprI_membered x, V y) {

			return new _eq.Call(x, y);

		}
		static public ExprI_membered Call( V y, bit.ExprI_membered x) {

			return new _eq.Call(y, x);

		}
	
	}
}
