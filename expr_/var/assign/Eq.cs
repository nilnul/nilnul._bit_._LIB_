using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.assignment
{
	public class Eq : IEqualityComparer<nilnul.bit.var.Assignment>, EqI
	{
		public bool Equals(Assignment x, Assignment y)
		{
			return nilnul.obj.var.Eq1.Instance.Equals((nilnul.obj.VarI1) x.var, (nilnul.obj.VarI1) y.var) && x.val == y.val;

			//throw new NotImplementedException();
		}

		public int GetHashCode(Assignment obj)
		{
			return obj.var.GetHashCode() ^ obj.val.GetHashCode();

			//throw new NotImplementedException();
		}


		static private Lazy<Eq> _Lazy = new Lazy<Eq>();
		static public Eq Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
