using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.duo.op
{
	/// <summary>
	/// imply
	/// </summary>
	public sealed class Le
		:nilnul.bit.duo.OpI1
	{
		static public bool Eval(bool x, bool y) {
			return Lt.Eval(x,y) | Eq.Eval(x,y);
		}

		public const char CHAR=' ';

		public static readonly string CHAR_AS_STR = CHAR.ToString();


		static public readonly Le Singleton = SingletonByDefault<Le>.Instance;
		[Obsolete()]
		public Le()
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
		public override string ToString()
		{
			return "<=";
		}
	}

	//public partial class Imply : Le {

	//}
}
