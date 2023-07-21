using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.stati.simpleSum.duo.op
{
	public class Mi
	{
		static public StatiI ToStati(simple.str.op.Disjunct.Call x,simple.str.op.Disjunct.Call y) {

			return bit.expr.stati.duo.Min.Call(x.toStati(), y.toStati());
		}
	}
}
