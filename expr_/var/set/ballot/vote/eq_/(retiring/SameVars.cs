using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.interpret.eq_
{
	/// <summary>
	/// in order to make sure the interpretations of truthTable is different.
	/// </summary>
	public class SameVars : IEqualityComparer<Interpretation>
	{
		public bool Equals(Interpretation x, Interpretation y)
		{
			return nilnul.bit.var.set.assignment.eq_.SameVars.Lazy.Equals(x.assignment, y.assignment)

				 
				
				;
			//throw new NotImplementedException();
		}

		public int GetHashCode(Interpretation obj)
		{
			return nilnul.bit.var.set.assignment.eq_.SameVars.Lazy.GetHashCode(obj.assignment)  ;
			//throw new NotImplementedException();
		}


		static private Lazy<SameVars> _Lazy = new Lazy<SameVars>();
		static public SameVars Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
