using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.duo.op
{
	public sealed class TailComplement:OpI
	{

		static public readonly TailComplement Singleton = SingletonByDefault<TailComplement>.Instance;

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
