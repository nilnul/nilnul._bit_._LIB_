using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  nilnul.bit.var.set.ballot.co_.sameKeys.be_
{
	/// <summary>
	/// assert that states are all sameVars, let's further consider whether they are of same vals.
	/// </summary>
	public class SameVals:IEqualityComparer<nilnul.bit.var.set.Ballot>
	{

		private nilnul.bit.var.Set2 _vars;

		public nilnul.bit.var.Set2 vars
		{
			get { return _vars; }
			set { _vars = value; }
		}

		public bool Equals(Ballot x, Ballot y)
		{
			return _vars.All(v=>  x[v]==y[v] );
			//throw new NotImplementedException();
		}

		public SameVals(nilnul.bit.var.Set2 vars)
		{
			_vars = vars;
		}
		public int GetHashCode(Ballot obj)
		{
			return 0;
			//throw new NotImplementedException();
		}


		

	}
}
