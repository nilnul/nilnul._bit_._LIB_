using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.interpret
{
	/// <summary>
	/// in order to make sure the interpretations of truthTable is different.
	/// </summary>
	public class Eq : IEqualityComparer<Interpretation>
	{
		public bool Equals(Interpretation x, Interpretation y)
		{
			return nilnul.bit.var.set.assignment.Eq.Lazy.Equals(x.assignment, y.assignment)

				&&

				x.result == y.result
				
				;
			//throw new NotImplementedException();
		}

		public int GetHashCode(Interpretation obj)
		{
			return obj.assignment.GetHashCode() ^ obj.result.GetHashCode();
			//throw new NotImplementedException();
		}
	}
}
