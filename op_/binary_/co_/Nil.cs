using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.combine_
{
	public partial class Nil:CombineI
	{

		static public readonly Nil Singleton = nilnul.obj.SingletonByDefault<Nil>.Instance;

		static public bool Eval(bool x, bool y) {
			return false;
		}
		[Obsolete()]
		public Nil()
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
