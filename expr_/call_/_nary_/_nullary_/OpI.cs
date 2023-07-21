using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_._nullary_
{
	[Obsolete()]
	public interface OpI
		:nilnul.obj.expr_._call_.OpI<nilnul.bit.Constant>
	{

	}
	[Obsolete()]
	public abstract class OpA:
		nilnul.obj.expr_._call_.OpA<Constant>
		,
		OpI
	{
		
		public OpA(bool  resultOfOp):base( new Constant(resultOfOp))
		{
		}

		

		
	}
}
