using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.var
{
	public class Eq : IEqualityComparer<bit.expr_.Var_sys>
	{
		public bool Equals(Var_sys x, Var_sys y)
		{
			return (x.ee==y.ee);
			//return object.ReferenceEquals(x.ee,y.ee);
			throw new NotImplementedException();
		}

		public int GetHashCode(Var_sys obj)
		{
			return obj.ee.GetHashCode();
			//throw new NotImplementedException();
		}

		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}

	}
}
