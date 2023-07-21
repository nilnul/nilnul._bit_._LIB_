using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op.unary.var
{
	public partial class Expr<P>
		:nilnul.obj.op.unary.var.ExprA<nilnul.bit.op.unary.VarI<P>,nilnul.obj.VarI<P>>
	{
		public Expr(
			nilnul.bit.op.unary.VarI<P> op,
			
			nilnul.obj.VarI<P> arg
			):base(op,arg)
		{


		}	
		


	}
}
