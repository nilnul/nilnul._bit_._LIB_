using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.var
{
	
	[Obsolete()]
	public class Set:
		Set_eqDefault<nilnul.bit.VarI1 , nilnul.bit.var.Eq>
		,nilnul.var.SetI<nilnul.bit.VarI1>
		
	
		
	{

		public Set()
		{

		}
		public Set(IEnumerable<nilnul.bit.VarI1> vars):base(vars)
		{

		}

	}
}
