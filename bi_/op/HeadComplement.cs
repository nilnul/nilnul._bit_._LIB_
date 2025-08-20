using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.duo.op
{

	public sealed class HeadComplement
		:OpI
	{
		static public readonly HeadComplement Singleton = SingletonByDefault<HeadComplement>.Instance;

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

	[Obsolete("",true)]
	public partial class N0
	{
		static public bool Eval(bool x, bool y)
		{
			return !x;
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
