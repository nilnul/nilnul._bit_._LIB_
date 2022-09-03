using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.interpret
{
	/// <summary>
	/// in order to Sort the interpretations of a truthTAble before output it as a list of txt.
	/// This will order the interpretation:
	///		1) order the assignment first
	///		2) order the result : 0 before 1.
	/// </summary>
	public class Comparer
		: IComparer<Interpretation>
	{
		public int Compare(Interpretation x, Interpretation y)
		{
			
			var assignCompared = nilnul.bit.var.set.assignment.Comparer.Lazy.Compare(x.assignment, y.assignment);
			if (assignCompared==0)
			{
				return nilnul.bit.Comparer.Lazy.Compare(x.result, y.result);
			}
			return assignCompared;

			//throw new NotImplementedException();
		}
	}
}
