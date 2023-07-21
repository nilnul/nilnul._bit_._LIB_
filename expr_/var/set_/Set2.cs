using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.var
{


	[Obsolete(nameof(bit.expr_.var.Set4generi))]
	public class Set2:
		nilnul.obj.Set<nilnul.bit.VarI1, var.Eq>
		
		
	{

		public Set2():base(  )
		{

		}

		public Set2(params nilnul.bit.VarI1[] vars):this(vars as IEnumerable<VarI1>)
		{

		}

		public Set2(IEnumerable<nilnul.bit.VarI1> vars):base(vars)
		{

		}
		static public Set2 CreateEmpty() {
			return new Set2();
		}

	}
}
