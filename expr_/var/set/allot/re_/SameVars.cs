using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.set.assignment.re_
{
	public class SameVars : nilnul.obj.ReI<Assignment>
	{
		public bool re(Assignment x, Assignment y)
		{
			return nilnul.obj.var.set.Eq.Lazy.Equals(x.vars,y.vars);
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
