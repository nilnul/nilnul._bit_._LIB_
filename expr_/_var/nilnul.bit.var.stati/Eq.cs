using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.stati
{
	public class Eq : IEqualityComparer<Stati>
	{
		static public Eq Instance = new Eq();

		static public Eq Singleton = SingletonByDefault<Eq>.Instance;	//null?

		static Eq() { }
		public bool Equals(Stati x, Stati y)
		{
			return x == y;

			throw new NotImplementedException();
		}

		public bool Ne(Stati x, Stati y) {
			return !Equals(x, y);
		}

		public int GetHashCode(Stati obj)
		{
			return obj.GetHashCode();
			throw new NotImplementedException();
		}
	}
}
