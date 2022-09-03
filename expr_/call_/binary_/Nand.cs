using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_.binary_
{

	
	public class Nand : Binary_sys
	{
		public Nand( Expr_sys arg, Expr_sys arg1) : base(bit.op_.binary_.Nand.Singleton, arg, arg1)
		{
		}
		public Nand( ExprI_sys arg, ExprI_sys arg1) : base(bit.op_.binary_.Nand.Singleton, arg, arg1)
		{
		}

	}
}
