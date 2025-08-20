using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.duo.op
{
	public sealed class Head
		:OpI
	{
		static public readonly Head Singleton = SingletonByDefault<Head>.Instance;


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


	[Obsolete("",true)]
	public partial class P0
	{
		static public bool Eval(bool x, bool y) {
			return x;
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
