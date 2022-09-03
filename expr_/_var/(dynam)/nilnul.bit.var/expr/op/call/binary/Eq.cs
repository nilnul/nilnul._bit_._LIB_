using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.var.expr.op.call.binary
{
	public partial class Eq

		:nilnul.obj.var.expr.op.binary.Closed<bool>.Call
	{
		public Eq( 
			nilnul.obj.var.ExprI<bool> arg 
			,
			nilnul.obj.var.ExprI<bool> arg1
		)
		:
		base(
			bit.op.binary.Eq.Singleton
			,arg
			,arg1
		)
		{

		}
	}
}
