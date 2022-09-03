using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_._binary_
{
	[Obsolete()]
	public interface OpI
		:nilnul.obj.expr_._call_.OpI<nilnul.bit.op_.BinaryI>
	{

	}
	[Obsolete()]
	public abstract class OpA:
		nilnul.obj.expr_._call_.OpA<nilnul.bit.op_.BinaryI>
		,
		OpI
	{
		
		public OpA(nilnul.bit.op_.BinaryI op):base(  op)
		{
		}

		

		
	}
}
