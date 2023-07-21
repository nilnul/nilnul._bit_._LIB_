using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op.unary
{
	public partial class Literal<TPara>
		:nilnul.obj.var.Literal<nilnul.bit.op.Unary<TPara>>
		,
		
		nilnul.bit.op.unary.VarI<TPara>
	{
		public Literal(bit.op.Unary<TPara> op)
			:base(op)
		{

		}

	}
}
