using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.assignment.eq_
{
	[Obsolete()]
	public class ByVar
		: EqI
	{
		public bool Equals(Assignment x, Assignment y)
		{
			return nilnul.bit.var.Eq.Singleton.Equals(x.var, y.var);

			//throw new NotImplementedException();
		}

		public int GetHashCode(Assignment obj)
		{
			return nilnul.bit.var.Eq.Singleton.GetHashCode(obj.var);

			//throw new NotImplementedException();
		}

		static public readonly ByVar Singleton = SingletonByDefault<ByVar>.Instance;

	}
}
