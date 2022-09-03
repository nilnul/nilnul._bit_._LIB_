using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.stati.set.str.op
{
	public class Union
		
	{
		static public Set _Eval(IEnumerable<Set> _str) {
			
			return _str.Aggregate(new Set(), (accumulated, next) => duo.op.Union.Eval(accumulated, next));
		}

	}
}
