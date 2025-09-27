using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op.binary
{
	[Obsolete()]
	public class Add:BinaryI
	{

		public const string STR_SlashedDoubleArrow = "↮";
		public const string STR_SlashedThree = "≢";
		/// <summary>
		/// plus sign (+). This makes sense mathematically because exclusive disjunction corresponds to addition modulo 2, which has the following addition table, clearly isomorphic to the one above
		/// </summary>
		public const string STR_PLUS = "+";

		static private readonly Add _Instance = new Add();
		static public Add Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Add()
		{
		}
				
		public bool exec(bool operand1, bool operand2)
		{
			return operand1 ^ operand2;
		}
		public override string ToString()
		{
			return STR_PLUS;
		}

		public bool eval(bool a, bool b)
		{

			return a ^ b;

			throw new NotImplementedException();
		}
	}
}
