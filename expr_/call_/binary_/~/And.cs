using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_.binary_
{

	
	[Obsolete()]
	public class And : Binary_sys
	{
		public And( Expr_sys arg, Expr_sys arg1) : base(bit.op_.binary_.And.Singleton, arg, arg1)
		{
		}

		public And( ExprI_sys arg, ExprI_sys arg1) : base(bit.op_.binary_.And.Singleton, arg, arg1)
		{
		}
	}
}
