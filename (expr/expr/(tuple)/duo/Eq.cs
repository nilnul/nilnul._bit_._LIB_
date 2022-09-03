using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.stati.duo
{
	public class Eq
	{
		static public StatiI Call(bit.var.stati.Stati x, bit.var.stati.Stati y) {

			return new _eq.Call(x, y);

		}

		static public StatiI Call(bit.expr.stati.StatiI x, bit.expr.stati.StatiI y) {

			return new _eq.Call(x, y);

		}
	
	}
}
