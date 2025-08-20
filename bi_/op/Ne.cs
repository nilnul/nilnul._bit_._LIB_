using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.duo.op
{
	/// <summary>
	/// Xor
	/// </summary>
	public sealed class Ne:OpI,OpI1
	{

		static public readonly Ne Singleton = SingletonByDefault<Ne>.Instance;
		static public bool Eval(bool x, bool y) {
			return x != y;
		}
		[Obsolete()]
		public Ne()
		{

		}
		public bool eval(bool x, bool y)
		{

			return x != y;

			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return "^";
		}
	}
}
