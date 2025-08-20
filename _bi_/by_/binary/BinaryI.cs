using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op.binary
{
	public partial interface BinaryI
		:nilnul.obj.op.binary.ClosedI<bool>
		,
		nilnul.bit.op.BinaryI
	{
		bool exec(bool x,bool y);
	}
}
