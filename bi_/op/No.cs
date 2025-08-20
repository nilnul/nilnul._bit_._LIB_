using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.duo.op
{
	public partial class No:OpI
	{

		static public readonly No Singleton = SingletonByDefault<No>.Instance;

		static public bool Eval(bool x, bool y) {
			return false;
		}
		[Obsolete()]
		public No()
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
