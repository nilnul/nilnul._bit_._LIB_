using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.str.op
{
	[Obsolete("Conjunct")]
	public partial class And
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
		public override string ToString()
		{
			return "Pi";
		}
		public const string SIGN = "PI";



	}
}
