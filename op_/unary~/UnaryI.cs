using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op.unary
{
	public partial interface UnaryI
		:nilnul.obj.op.unary.ClosedI1<bool>
	{
		bool exec(bool a);
	}
}
