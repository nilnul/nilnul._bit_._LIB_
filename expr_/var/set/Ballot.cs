using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.expr_.Var2;

namespace nilnul.bit.expr_.var.set
{




	public class Ballot
		:
		nilnul.obj.dict_.Poll<nilnul.bit.expr_.Var2,  nilnul.bit.expr_.var.Eq>
		,
		IBallot
	{
		public Ballot(Dictionary<V, bool> dict):base(dict)
		{
		}
		public Ballot():this(new Dictionary<V, bool>())
		{

		}


		static public Ballot _Create__assumeSameCount(IEnumerable<V> vars1, IEnumerable<bool> vals

		)
		{

			var r = new Ballot();
			for (int i = 0; i < vars1.Count(); i++)
			{
				r.Add(vars1.ElementAt(i), vals.ElementAt(i));
			}
			return r;

		}
	}
}
