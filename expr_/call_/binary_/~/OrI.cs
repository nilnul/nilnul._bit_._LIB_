using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_.binary_
{

[Obsolete()]

	public class Or : bit.expr_.call_.Binary_sys
	{
		public Or( Expr_sys arg, Expr_sys arg1) : base(bit.op_.binary_.Or.Singleton, arg, arg1)
		{
		}

		public Or(ExprI_sys x, ExprI_sys y):base(bit.op_.binary_.Or.Singleton, x,y)
		{
		}
	}


}
