using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.plain_.call.be
{
	public class En<TBe> : nilnul.obj.be.En2<CallI, TBe>
		where TBe : BeI, new()
	{
		public En(CallI val) : base(val)
		{
		}
	}
}
