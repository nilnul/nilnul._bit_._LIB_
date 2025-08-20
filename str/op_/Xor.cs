using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.str.be;
using nilnul.str.seed;

namespace nilnul.bit.str.op
{
	public partial class Xor
	{
		public const bool UNIT = false;
		
		static public bool Eval_byUnitaryRecur(IEnumerable<bool> elements) {

			return elements.None() ? UNIT : elements.First() ^ Eval_byUnitaryRecur(elements.Tail());
		
		}

		static public bool Eval(params bool[] elements) {
			return Eval_byUnitaryRecur(elements as IEnumerable<bool> );
		}
		public override string ToString()
		{
			return "Pi";
		}
		public const string SIGN = "PI";



	}
}
