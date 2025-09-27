using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op.binary
{
	[Obsolete()]
	public class Add1:BinaryI
	{
		public const char Modulo_Addition_Char = '\u2295';//⊕ 0x2295
			
		static public bool Eval(bool x, bool y)
		{
			return x ^ y;
		}

		public bool exec(bool a, bool b)
		{
			return Eval(a, b);
			throw new NotImplementedException();
		}

		public bool eval(bool a, bool b)
		{
			return Eval(a, b);
			throw new NotImplementedException();
		}
	}
}
