using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  nilnul.bit.var.set.state.eq_.sameVars
{
	/// <summary>
	/// assert that states are all sameVars, let's further consider whether they are of same vals.
	/// </summary>
	///
	[Obsolete()]
	public class SameVals:IEqualityComparer<nilnul.bit.var.set.State>
	{

		private nilnul.bit.var.Set1 _vars;

		public nilnul.bit.var.Set1 vars
		{
			get { return _vars; }
			set { _vars = value; }
		}

		public bool Equals(State x, State y)
		{
			return _vars.All(v=>  x[v]==y[v] );
			//throw new NotImplementedException();
		}

		public SameVals(nilnul.bit.var.Set1 vars)
		{
			_vars = vars;
		}
		public int GetHashCode(State obj)
		{
			return 0;
			//throw new NotImplementedException();
		}


		

	}
}
