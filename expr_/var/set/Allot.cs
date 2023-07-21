using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.var.set
{


	[Obsolete(nameof(bit.expr_.var.set.Sel))]

	public class Allot
		:
		nilnul.obj.dict_.Poll<nilnul.bit.expr_.Var_sys,  nilnul.bit.expr_.var.Eq>
		,
		ISel
	{
		public Allot(Dictionary<nilnul.bit.expr_.Var_sys, bool> dict):base(dict)
		{
		}
		public Allot():this(new Dictionary<nilnul.bit.expr_.Var_sys, bool>())
		{

		}


		static public Allot _Create__assumeSameCount(IEnumerable<bit.expr_.Var_sys> vars1, IEnumerable<bool> vals

		)
		{

			var r = new Allot();
			for (int i = 0; i < vars1.Count(); i++)
			{
				r.Add(vars1.ElementAt(i), vals.ElementAt(i));
			}
			return r;

		}
	}
}
