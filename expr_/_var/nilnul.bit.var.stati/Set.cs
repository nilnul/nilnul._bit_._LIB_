using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.var.stati
{
	

	public class Set:Set_eqDefault<Stati,Eq>
	{

		public Set()
		{

		}
		public Set(IEnumerable<Stati> vars):base(vars)
		{

		}

	}
}
