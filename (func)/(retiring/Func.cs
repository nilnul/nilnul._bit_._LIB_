using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit
{
	[Obsolete(nameof(Func1))]
	public class Func:nilnul._func.Func_typeParaConstrained<nilnul.bit.var.TuplI,nilnul.bit.ExprI_membered>
	{

		public Func(nilnul.bit.var.TuplI vars, nilnul.bit.ExprI_membered expr)
			:base(vars,expr)
		{

		}

	}
}
