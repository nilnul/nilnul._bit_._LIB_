using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_.binary_
{


	public class Xor : Binary_sys
	{
		public Xor( Expr_sys arg, Expr_sys arg1) : base(bit.op_.binary_.Xor.Singleton, arg, arg1)
		{
		}

		public Xor( ExprI_sys arg, ExprI_sys arg1) : base(bit.op_.binary_.Xor.Singleton, arg, arg1)
		{
		}
	}
}
