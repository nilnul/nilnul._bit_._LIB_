using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.str.summarize_
{
	static public class _ConjunctX
	{
		static public bool Summarize(IEnumerable<bool> elements)
		{
			return Summarize_byLoop(
				elements
			);
		}
		static public bool Summarize(params bool[] elements)
		{
			return Summarize(
				(IEnumerable<bool>)elements
			);
		}

		static public bool Summarize_byRecur(IEnumerable<bool> elements)
		{
			if (elements.Any())
			{
				return elements.First() && Summarize(elements.Skip(1));

			}
			else
			{
				return true;
			}
		}

		static public bool Summarize_byLoop(IEnumerable<bool> elements)
		{

			var r = true;
			var enumerator = elements.GetEnumerator();
			while (enumerator.MoveNext())
			{
				r = r && enumerator.Current;
			}
			return r;
		}

	}
}
