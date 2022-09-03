using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.stati.duo
{
	public class Min
	{
		static public StatiI Call(bit.var.stati.Stati x, bit.var.stati.Stati y) {

			return new duo.Call( bit.duo.op.Mi.Instance, x, y);

		}

		static public StatiI Call(bit.expr.stati.StatiI x, bit.var.stati.Stati y) {

			return new duo.Call( bit.duo.op.Mi.Instance, x, y);

		}
		static public StatiI Call(bit.expr.stati.StatiI x, bit.expr.stati.StatiI y) {

			return new duo.Call( bit.duo.op.Mi.Instance, x, y);

		}


		
	}
}
