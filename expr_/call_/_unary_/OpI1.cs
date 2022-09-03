using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_._unary_
{
	public interface OpI1
		:nilnul.obj.expr_._call_.OpI<nilnul.bit.op_.UnaryI1>
	{

	}
	public abstract class OpA1:
		nilnul.obj.expr_._call_.OpA<nilnul.bit.op_.UnaryI1>
		,
		OpI1
	{
		
		public OpA1(nilnul.bit.op_.UnaryI1 op):base(  op)
		{
		}

		

		
	}
}
