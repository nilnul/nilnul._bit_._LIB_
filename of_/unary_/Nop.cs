using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op_.unary_
{
	public class Nop : UnaryI
	{
		public bool op(bool par)
		{
			return par;
			throw new NotImplementedException();
		}

		static public Nop Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Nop>.Instance;
			}
		}

	}
}
