using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.varAs
{
	public class Eq : IEqualityComparer<VarAsExpr>
	{

		static public readonly Eq Singleton = SingletonByDefault<Eq>.Instance;
		public bool Equals(VarAsExpr x, VarAsExpr y)
		{
			return nilnul.bit.var.Eq.Singleton.Equals(x.var, y.var);

			throw new NotImplementedException();
		}

		public int GetHashCode(VarAsExpr obj)
		{
			return nilnul.bit.var.Eq.Singleton.GetHashCode(obj.var);
			throw new NotImplementedException();
		}
	}
}
