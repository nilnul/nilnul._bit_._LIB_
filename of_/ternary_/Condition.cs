using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.ternary_
{
	public class Condition
		:
		op_.TernaryA,

		TernaryI
		

	{
		public override bool op(bool x, bool y, bool z) {
			return x  ? y : z;
		}
	}
}
