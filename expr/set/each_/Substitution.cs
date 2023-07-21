using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;
using E = nilnul.bit.ExprI_membered;
namespace nilnul.bit.expr.set
{
	public class Substitution:Dictionary<V,E>
	{

		public Substitution()
		{

		}

		public IEnumerable<nilnul.bit.expr.Substitution> enumerate()
		{
			return this.Select(a => new expr.Substitution(a));
		}





	}
}
