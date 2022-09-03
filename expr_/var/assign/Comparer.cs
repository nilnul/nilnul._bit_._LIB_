using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.assign
{
	public class Comparer : IComparer<Assign>
	{
		public int Compare(Assign x, Assign y)
		{
			var varCompared = nilnul.obj.var.comparer_.FroNaming.Lazy.Compare(x.var, y.var);

			if (varCompared==0)
			{
				return nilnul.bit.Comparer.Lazy.Compare(x.val, y.val);

			}
			return varCompared;
			//throw new NotImplementedException();
		}

		static private Lazy<Comparer> _Lazy = new Lazy<Comparer>();
		static public Comparer Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
