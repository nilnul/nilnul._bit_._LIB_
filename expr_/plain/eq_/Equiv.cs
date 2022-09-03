using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.plain.eq_
{
	public class Equiv : EqI
	{
		public bool Equals(PlainI x, PlainI y)
		{
			return be_.Tauto.Singleton.be(
				nilnul.bit.expr_.plain_.call_.Binary.CreateEq(
					x
					,
					y
				)
			);
			//throw new NotImplementedException();
		}

		public int GetHashCode(PlainI obj)
		{
			return 0;
			throw new NotImplementedException();
		}

		static public Equiv Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Equiv>.Instance;
			}
		}

	}
}
