using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.stati.set.duo.op
{
	public class Union
	{
		static public Set Eval(Set x,Set y) {
			var r = new Set();
			r.UnionWith(x);
			r.UnionWith(y);
			return r;
		}
	}
}
