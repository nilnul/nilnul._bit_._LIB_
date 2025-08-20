using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.combine_
{
	/// <summary>
	/// biconditional, equivalence, iif,eq
	/// </summary>
	public sealed class Eq:CombineI
	{

		static public readonly Eq Singleton = SingletonByDefault<Eq>.Instance;
		static public bool Eval(bool x, bool y) {
			return x == y;
		}


		public const char EQUAL='=';
		public bool exec(bool a, bool b)
		{
			return a==b;
		}


		public bool eval(bool x, bool y)
		{

			return x == y;

			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return "\u2194";
		}
	}
}
