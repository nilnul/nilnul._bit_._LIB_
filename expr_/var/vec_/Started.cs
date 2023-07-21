using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;

namespace nilnul.bit.var.tupl
{
	public class Started:nilnul.var.tupl.Seed<V, TuplI>,TuplI
	{
		public Started( V head, TuplI tail):base(head,tail)
		{

		}
	}
}
