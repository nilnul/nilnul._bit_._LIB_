using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.expr_.Var2;

namespace nilnul.bit.expr_.var
{
	public class Set4generi : nilnul.obj.set_.EqDefaulted<V, Eq>
	{
		public Set4generi()
		{
		}

		public Set4generi(params V[] vars) : base(vars)
		{
		}

		public Set4generi(IEnumerable<V> elements) : base(elements)
		{
		}

		

		
	}
}
