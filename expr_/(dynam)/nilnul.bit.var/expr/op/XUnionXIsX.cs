using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.var.expr.op
{
	public partial class XUnionXEqX
		:nilnul.obj.var.expr.op.binary.ClosedI<bool>.Call
	{
		public XUnionXEqX()
			:base(
				new nilnul.obj.var.expr.op.Binary<bool,bool,bool>(new nilnul.bit.op.binary.Or_defaultCtor()
				,

			)
		{

		}


	}
}
