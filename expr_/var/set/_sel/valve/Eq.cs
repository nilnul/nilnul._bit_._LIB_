using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr.be;

namespace nilnul.bit.expr.simple
{
	public class Eq : IEqualityComparer<expr.be.Simple.Asserted>
	{
		public bool Equals(Simple.Asserted x, Simple.Asserted y)
		{
			if (x.val is bit.expr.AtomI)
			{
				if (y.val is bit.expr.AtomI)
				{
					return bit.expr.atom.Eq.Singleton.Equals(x as AtomI, y as AtomI);
				}
				else
				{
					return false;
				}


			}
			else //negVar
			{
				if (y.val is expr.Call)
				{
					return nilnul.bit.var.Eq.Singleton.Equals(((x.val as expr.Call).arg as VarAsExpr).var, ((y.val as expr.Call).arg as VarAsExpr ).var);
				}
				return false;

			}

			throw new NotImplementedException();
		}

		public int GetHashCode(Simple.Asserted obj)
		{
			return obj.val.GetHashCode();
			throw new NotImplementedException();
		}
	}
}
