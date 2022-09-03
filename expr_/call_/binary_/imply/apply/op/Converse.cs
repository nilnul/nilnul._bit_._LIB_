using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.duo.op.imply.apply.op
{
	public class Converse
	{
		public Apply eval(Apply x) {
			return new Apply(
				(x.arg1)
				,
				(x.arg)
			);
		}
	}
}
