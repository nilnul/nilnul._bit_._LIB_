using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var
{
	public class Eq : IEqualityComparer<nilnul.bit.VarI1>
	{
		static public Eq Instance = new Eq();

		static public Eq Singleton = SingletonByDefault<Eq>.Instance;	//null?

		static Eq() { }
		public bool Equals(nilnul.bit.VarI1 x, nilnul.bit.VarI1 y)
		{
			return x == y;

			//throw new NotImplementedException();
		}

		public bool Ne(nilnul.bit.VarI1 x, nilnul.bit.VarI1 y) {
			return !Equals(x, y);
		}

		public int GetHashCode(nilnul.bit.VarI1 obj)
		{
			return obj.GetHashCode();
			//throw new NotImplementedException();
		}
	}
}
