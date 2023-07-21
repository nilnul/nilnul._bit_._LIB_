using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.set.assignment.eq_
{
	/// <summary>
	/// 
	/// </summary>
	public class SameVars : IEqualityComparer<Assignment>
	{
		public bool Equals(Assignment x, Assignment y)
		{


			return nilnul.bit.var.set.Eq.Instance.Equals(x.vars, y.vars);

			//throw new NotImplementedException();
		}

		public int GetHashCode(Assignment obj)
		{
			return obj.vars.GetHashCode();
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
