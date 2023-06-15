using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op.binary
{

	[Obsolete()]
	public class One:bit.op.BinaryI
	{
		static public bool Eval(bool x, bool y) {
			return true;
		}

		public bool exec(bool x, bool y)
		{
			return Eval(x, y);
			throw new NotImplementedException();
		}

		public bool eval(bool x, bool y)
		{
			return Eval(x, y);

			throw new NotImplementedException();
		}

		
	}
}
