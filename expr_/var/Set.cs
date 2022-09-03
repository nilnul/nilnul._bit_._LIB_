using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.var
{
	public class Set : nilnul.obj.set_.EqDefaulted<expr_.Var_sys, Eq>
	{
		public Set()
		{
		}

		public Set(params Var_sys[] vars) : base(vars)
		{
		}

		public Set(IEnumerable<Var_sys> elements) : base(elements)
		{
		}

		

		
	}
}
