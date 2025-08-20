using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.duo.op
{
	public sealed class Tail
		:
		SingletonByDefault<Tail>
		,
		OpI
	{

		static public readonly Tail Singleton = SingletonByDefault<Tail>.Instance;
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

	[Obsolete("",true)]
	public partial class P1
	{
		static public bool Eval(bool x, bool y) {
			return y;
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
