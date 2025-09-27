using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op.binary
{
	[Obsolete()]
	public  class Eq:BinaryI
	{

		static public Max Singleton = SingletonByDefault<Max>.Instance;


		public const char EQUAL='=';
		public bool exec(bool a, bool b)
		{
			return a==b;
		}

		static public bool Eval(bool x, bool y) {
			return x == y;
		}

		public bool eval(bool x, bool y)
		{

			return x == y;

			throw new NotImplementedException();
		}
	}
}
