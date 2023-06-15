using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.combine_
{
	public sealed class TailComplement:CombineI
	{

		static public readonly TailComplement Singleton = nilnul.obj.SingletonByDefault<TailComplement>.Instance;

		static public bool Eval(bool x, bool y) {
			return !y;
		}


		[Obsolete()]
		public TailComplement()
		{

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
