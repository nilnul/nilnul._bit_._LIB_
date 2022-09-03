using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_._unary_
{
	[Obsolete()]
	public interface OpI
		:nilnul.obj.expr_._call_.OpI<nilnul.bit.op_.UnaryI>
	{

	}
	public abstract class OpA:
		nilnul.obj.expr_._call_.OpA<nilnul.bit.op_.UnaryI>
		,
		OpI
	{
		
		public OpA(nilnul.bit.op_.UnaryI op):base(  op)
		{
		}

		

		
	}
}
