using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op_.unary_
{
	[Obsolete()]
	public class Not : UnaryI
	{
		public bool op(bool par)
		{
			return !par;
			throw new NotImplementedException();
		}

		static public Not Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Not>.Instance;
			}
		}

	}
}
