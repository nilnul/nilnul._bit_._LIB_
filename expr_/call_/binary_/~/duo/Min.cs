using nilnul.bit.expr.stati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.duo
{
	public class Min
	{
		static public ExprI_membered Call(bit.VarI1 x, bit.VarI1 y) {

			return new duo.Call( bit.duo.op.Mi.Instance, x, y);

		}

		static public ExprI_membered Call(bit.ExprI_membered x, bit.VarI1 y) {

			return new duo.Call( bit.duo.op.Mi.Instance, x, y);

		}
		static public ExprI_membered Call(bit.ExprI_membered x, bit.ExprI_membered y) {

			return new duo.Call( bit.duo.op.Mi.Instance, x, y);

		}


		
	}
}
