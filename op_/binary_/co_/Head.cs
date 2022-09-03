using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.combine_
{
	public sealed class Head
		:CombineI
	{
		static public readonly Head Singleton = nilnul.obj.SingletonByDefault<Head>.Instance;


		static public bool Eval(bool x, bool y) {
			return x;
		}

		[Obsolete()]
		public Head()
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
