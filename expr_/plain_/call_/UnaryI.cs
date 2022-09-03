using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.plain_.call_
{
	public interface UnaryI:

		CallI
		, nilnul.obj.call_._unary_.OpArgI<nilnul.bit.op_.UnaryI1, PlainI>
		,SimpleI

	{
	}
}
