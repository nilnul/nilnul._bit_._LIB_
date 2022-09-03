using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.combine_
{
	public sealed class Ge
	{
		static public readonly Ge Singleton = nilnul.obj.SingletonByDefault<Ge>.Instance;

		static public bool Eval(bool x, bool y) {
			return Gt.Eval(x,y) | Eq.Eval(x,y);
		}

		public const char CHAR=' ';

		public static readonly string CHAR_AS_STR = CHAR.ToString();

		[Obsolete()]
		public Ge()
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
