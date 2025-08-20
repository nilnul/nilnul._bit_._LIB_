using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.set.state.interpret.eq_
{
	/// <summary>
	/// in order to make sure the interpretations of truthTable is different.
	/// </summary>
	public class SameVars : IEqualityComparer<nilnul.bit.var.set.state.Interpret>
	{
		public bool Equals(Interpret x, Interpret y)
		{
			return nilnul.bit.var.set.state.eq_.SameVars.Lazy.Equals(x.state, y.state)

				 
				
				;
			//throw new NotImplementedException();
		}

		public int GetHashCode(Interpret obj)
		{
			return nilnul.bit.var.set.state.eq_.SameVars.Lazy.GetHashCode(obj.state)  ;
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
