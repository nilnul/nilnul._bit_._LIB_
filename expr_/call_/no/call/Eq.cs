using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.no.call
{
	public class Eq : IEqualityComparer<no.Call>
	{
		static public readonly Eq Singleton = SingletonByDefault<Eq>.Instance;
		public bool Equals(Call x, Call y)
		{
			return x.eval() == y.eval();

			throw new NotImplementedException();
		}

		public int GetHashCode(Call obj)
		{
			return obj.eval().GetHashCode();
			throw new NotImplementedException();
		}
	}
}
