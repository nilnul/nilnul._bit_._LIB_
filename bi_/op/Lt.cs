using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.duo.op
{
	public partial class Lt
	{
		static public readonly Lt Singleton = SingletonByDefault<Lt>.Instance;

		static public bool Eval(bool x, bool y) {
			return !x & y;
		}

		public const char CHAR='<';

		public static readonly string CHAR_AS_STR = CHAR.ToString();
		[Obsolete()]
		public Lt()
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
