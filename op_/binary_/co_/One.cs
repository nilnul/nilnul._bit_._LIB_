using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.combine_
{
	public partial class One:bit.CombineI
		
	{

		static public readonly One Singleton = nilnul.obj.SingletonByDefault<One>.Instance;
		[Obsolete()]
		public One()
		{

		}

		static public bool Eval(bool x, bool y) {
			return true;
		}

		public bool exec(bool x, bool y)
		{
			return Eval(x, y);
			throw new NotImplementedException();
		}

		public bool eval(bool x, bool y)
		{
			return Eval(x, y);

			throw new NotImplementedException();
		}
	}
}
