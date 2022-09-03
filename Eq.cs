using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit
{
	public interface EqI : IEqualityComparer<bool>
	{ }
	public class Eq : IEqualityComparer<bool>
	{
		public bool Equals(bool x, bool y)
		{
			return x == y;
			throw new NotImplementedException();
		}

		public int GetHashCode(bool obj)
		{
			return obj ? 1 : 0;
			//throw new NotImplementedException();
		}


		static public Eq Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Eq>.Instance;
			}
		}

	}
}
