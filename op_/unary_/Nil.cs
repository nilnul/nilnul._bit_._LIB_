using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op_.unary_
{
	public class Nil : UnaryI
	{
		public bool op(bool par)
		{
			return false;
			throw new NotImplementedException();
		}

		static public Nil Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Nil>.Instance;
			}
		}

	}
}
