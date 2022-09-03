using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.ExprI_membered;
using V = nilnul.bit.VarI1;

namespace nilnul.bit.expr.tauto
{
	public class Asserted:nilnul.assert.Asserted_assertDefault<E,nilnul.bit.expr.tauto.Assert>
	{


		public Asserted(E e ):base(e)
		{

		}
	}
}
