using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op.binary
{
	[Obsolete()]
	public  class Pow:BinaryI
	{
		static public bool Eval(bool x, bool y) {
			return Gt.Eval(x,y) | Eq.Eval(x,y);
		}

		public const char CHAR=' '; //>=




		public bool exec(bool a, bool b)
		{
			return Eval(a, b);
			throw new NotImplementedException();
		}

		public bool eval(bool x, bool y)
		{
				return Eval(x, y);
		throw new NotImplementedException();
		}
	}
}
