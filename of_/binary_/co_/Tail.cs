using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.combine_
{
	public sealed class Tail
		:
		CombineI
	{

		static public readonly Tail Singleton = nilnul.obj.SingletonByDefault<Tail>.Instance;
		[Obsolete()]
		public Tail()
		{

		}
		public bool eval(bool x, bool y)
		{
			return y;
			throw new NotImplementedException();
		}
	}

	
}
