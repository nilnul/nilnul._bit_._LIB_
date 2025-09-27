using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op.binary
{
	[Obsolete("see Ne")]
	public class Xor_pubCtor:BinaryI
	{

		public const string STR_SlashedDoubleArrow = "↮";
		public const string STR_SlashedThree = "≢";
		public const char Modulo_Addition_Char = '\u2295';//⊕0x2295
		/// <summary>
		/// plus sign (+). This makes sense mathematically because exclusive disjunction corresponds to addition modulo 2, which has the following addition table, clearly isomorphic to the one above
		/// </summary>
		public const string STR_PLUS = "+";

		public bool exec(bool operand1, bool operand2)
		{
			return operand1 ^ operand2;
		}
		public override string ToString()
		{
			return STR_SlashedDoubleArrow;
		}

		public bool eval(bool x, bool y)
		{
				return x ^ y;
		throw new NotImplementedException();
		}
	}
}
