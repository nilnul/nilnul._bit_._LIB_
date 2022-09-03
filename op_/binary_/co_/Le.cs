using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.combine_
{
	/// <summary>
	/// imply
	/// </summary>
	/// <remarks>
	///	aka: imply, le, function mapping
	/// </remarks>
	public sealed class Le
		:nilnul.bit.CombineI
	{
		static public bool Eval(bool x, bool y) {
			return Lt.Eval(x,y) | Eq.Eval(x,y);
		}

		public const char CHAR=' ';

		public static readonly string CHAR_AS_STR = CHAR.ToString();


		static public readonly Le Singleton = nilnul.obj.SingletonByDefault<Le>.Instance;
		

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
