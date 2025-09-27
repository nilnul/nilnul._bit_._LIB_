using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.var;

namespace nilnul.bit.expr_.call_.binary_
{
	public class Iff_sys : Binary_sys

	{
		public Iff_sys(Expr_sys arg, Expr_sys arg1) : base(bit.op_.binary_.Iff.Singleton, arg, arg1)
		{
		}
		public Iff_sys(ExprI_sys arg, ExprI_sys arg1) : base(bit.op_.binary_.Iff.Singleton, arg, arg1)
		{
		}
	}
}
