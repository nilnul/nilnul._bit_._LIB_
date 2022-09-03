using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_._nary_
{
	public interface OpI
		:nilnul.obj.expr_._call_.OpI<nilnul.bit.op_.NaryI>
	{

	}
	public abstract class OpA:
		nilnul.obj.expr_._call_.OpA<nilnul.bit.op_.NaryI>
		,
		OpI
	{
		
		public OpA(bool  resultOfOp):base(  nilnul.bit.op_.NaryA.Create(resultOfOp))
		{
		}

		

		
	}
}
