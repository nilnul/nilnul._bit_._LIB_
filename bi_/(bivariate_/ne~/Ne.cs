using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op.binary
{
	[Obsolete()]
	public  class Ne:op.BinaryI
	{

		static public bool Eval(bool x, bool y) {
			return x != y;
		}

		public bool eval(bool x, bool y)
		{

			return x != y;

			throw new NotImplementedException();
		}
	}
}
