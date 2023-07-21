using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.combine_
{

	public sealed class HeadComplement
		:CombineI
	{
		static public readonly HeadComplement Singleton = nilnul.obj.SingletonByDefault<HeadComplement>.Instance;

		static public bool Eval(bool x, bool y)
		{
			return !x;
		}

		[Obsolete()]
		public HeadComplement()
		{

		}

		public bool exec(bool a, bool b)
		{
			return Eval(a, b);
			throw new NotImplementedException();
		}

		public bool eval(bool x, bool y)
		{
			return Eval(x, y);

			throw new NotImplementedException();
		}
	}

	
}
