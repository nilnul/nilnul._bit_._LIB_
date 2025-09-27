using nilnul.bit.expr.stati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.duo
{
	public class Max
	{
		[Obsolete("Call")]
		static public ExprI_membered Create(bit.VarI1 x, bit.VarI1 y) {

			return new _max.Call(x, y);

		}

		static public ExprI_membered Call(bit.VarI1 x, bit.VarI1 y) {

			return new _max.Call(x, y);

		}
		static public ExprI_membered Call(bit.ExprI_membered x, bit.ExprI_membered y) {

			return new _max.Call(x, y);

		}

		static public ExprI_membered Call(bool x, bit.VarI1 y) {

			return new _max.Call(x, y);

		}



		
	}
}
