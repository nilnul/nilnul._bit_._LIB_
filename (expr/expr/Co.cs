using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr
{
	public class Co : nilnul.obj.Co<nilnul.bit.ExprI3>
	{
		public Co(Tuple<ExprI3, ExprI3> tuple) : base(tuple)
		{
		}

		public Co((ExprI3, ExprI3) valTuple) : base(valTuple)
		{
		}

		public Co(ExprI3 item1, ExprI3 item2) : base(item1, item2)
		{
		}
	}
}
