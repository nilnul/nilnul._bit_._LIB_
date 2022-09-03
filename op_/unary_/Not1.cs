using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op_.unary_
{
	public class Not1 : UnaryI1
	{
		public const string TXT = "!";
		public bool op(bool par)
		{
			return !par;
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return TXT;
		}
		static public Not1 Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Not1>.Instance;
			}
		}

	}
}
