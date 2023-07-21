using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.var.expr.op.call
{
	public partial class Not

		:nilnul.obj.var.expr.op.unary.Closed<bool>.Call
	{
		public Not( nilnul.obj.var.ExprI<bool> arg  )
			:base(bit.op.unary.Not.Singleton,arg)
		{

		}
	}
}
