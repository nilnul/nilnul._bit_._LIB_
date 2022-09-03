using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.duo.op.imply.apply.op
{
	public class Inverse
	{
		public Apply eval(Apply x) {
			return new Apply(
				nilnul.bit.expr.Call.CreateNeg(x.arg)
				,
				nilnul.bit.expr.Call.CreateNeg(x.arg1)
			);
		}
	}
}
