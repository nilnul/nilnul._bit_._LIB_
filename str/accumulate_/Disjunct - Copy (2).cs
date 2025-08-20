using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.str.summarize_
{
	static public  class _DisjunctX
	{
		static public bool Summarize(IEnumerable<bool> elements) {
			return Summarize_byLoop(
				elements
			);
		}

		static public bool Summarize_byRecur(IEnumerable<bool> elements) {
			if (elements.Any())
			{
				return elements.First() | Summarize(elements.Skip(1));
				
			}
			else
			{
				return false;
			}
		}

		static public bool Summarize_byLoop(IEnumerable<bool> elements) {

			var r = true;
			var enumerator = elements.GetEnumerator();
			while (enumerator.MoveNext())
			{
				r |= enumerator.Current;
			}
			return r;
		}

		public const char SYMBOL = '⨈'; // U+2A08  
										//∑ 2211 N-ary summation
	}
}
