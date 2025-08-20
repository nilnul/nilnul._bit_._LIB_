using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.str.be;
using nilnul.str.seed;

namespace nilnul.bit.str.op
{
	[Obsolete(nameof(nilnul.bit.str.summarize_._ConjunctX))]
	public partial class Conjunct
	{
		static public bool Eval(IEnumerable<bool> elements) {

			if (elements.Any())
			{
				return elements.First() & Eval(elements.Skip(1));
				
			}
			else
			{
				return true;
			}
		
		}
		static public bool Eval_byUnitaryRecur(IEnumerable<bool> elements) {

			return elements.None() ? true : elements.First() && Eval_byUnitaryRecur(elements.Tail());
		
		}

		static public bool Eval(params bool[] elements) {
			return Eval(elements as IEnumerable<bool> );
		}
		public override string ToString()
		{
			return "Pi";
		}
		public const string SIGN = "PI";



	}
}
