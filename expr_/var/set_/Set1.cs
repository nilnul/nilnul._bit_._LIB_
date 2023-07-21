using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.var
{
	
	[Obsolete()]
	public class Set1:
		nilnul.obj.var.Set<bool, nilnul.bit.VarI1>
		
		
	{

		public Set1():base(  )
		{

		}

		public Set1(params nilnul.bit.VarI1[] vars):this(vars as IEnumerable<VarI1>)
		{

		}

		public Set1(IEnumerable<nilnul.bit.VarI1> vars):base(vars)
		{

		}
		static public Set1 CreateEmpty() {
			return new Set1();
		}

	}
}
