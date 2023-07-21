using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_._nullary_
{
	public interface OpI1
		:nilnul.obj.expr_._call_.OpI<nilnul.bit.op_.NaryI>
	{

	}
	public abstract class OpA1:
		nilnul.obj.expr_._call_.OpA<nilnul.bit.op_.NaryI>
		,
		OpI1
	{
		
		public OpA1(bool  resultOfOp):base(  nilnul.bit.op_.NaryA.Create(resultOfOp))
		{
		}

		

		
	}
}
