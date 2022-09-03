using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.be
{
	public class En<TBe> : nilnul.obj.be.En2<nilnul.bit.ExprI3, TBe>
		where TBe : nilnul.bit.expr.BeI1, new()
	{
		public En(ExprI3 val) : base(val)
		{
		}
	}
}
