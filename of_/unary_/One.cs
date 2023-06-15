using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op_.unary_
{
	public class One : UnaryI
	{
		public bool op(bool par)
		{
			return true;
			throw new NotImplementedException();
		}

		static public One Singleton
		{
			get
			{
				return nilnul._obj.Singleton<One>.Instance;
			}
		}

	}
}
