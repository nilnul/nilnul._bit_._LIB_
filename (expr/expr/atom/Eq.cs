using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.atom
{
	public class Eq : IEqualityComparer<AtomI>
	{
		static public readonly Eq Singleton = SingletonByDefault<Eq>.Instance;
		public bool Equals(AtomI x, AtomI y)
		{
			if (x is VarAsExpr)
			{
				if (y is VarAsExpr)
				{
					return varAs.Eq.Singleton.Equals(x as VarAsExpr, y as VarAsExpr);
				}
				return false;
			}
			else if (x is no.Call)
			{
				if (y is no.Call)
				{
					return no.call.Eq.Singleton.Equals(x as no.Call, y as no.Call);
				}
				return false;

			}
			else
			{
				throw new UnexpectedTypeException();
			}
			
			throw new NotImplementedException();
		}

		public int GetHashCode(AtomI obj)
		{
			return obj.GetHashCode();
			throw new NotImplementedException();
		}
	}
}
