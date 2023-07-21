using nilnul.bit.expr.stati.be;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using nilnul.bit.expr.be;

namespace nilnul.bit.expr.simple
{
	public class Set
		:nilnul.Set_eqDefault<expr.be.Simple.Asserted, expr.simple.Eq>
	{
		public Set()
		{

		}

		public Set(IEnumerable<be.Simple.Asserted> vals) : base(vals)
		{
		}
	}
}
