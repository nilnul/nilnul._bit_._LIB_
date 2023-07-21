using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_
{
	[Obsolete(nameof(bit.IOf))]
	public interface IOf:bit.IOp
		,
		nilnul.obj.op_.IOf<bool>
	{

	}

	
}
