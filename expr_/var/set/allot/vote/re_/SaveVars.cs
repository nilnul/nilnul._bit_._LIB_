using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.interpret.re_
{
	public class SaveVars : nilnul.obj.ReI<
		Interpretation
		>
	{
		public bool re(Interpretation x, Interpretation y)
		{
			return nilnul.bit.var.set.assignment.re_.SameVars.Lazy.re(x.assignment,y.assignment);

			//throw new NotImplementedException();
		}
	}
}
