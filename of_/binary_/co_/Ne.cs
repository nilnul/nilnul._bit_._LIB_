using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.combine_
{
	/// <summary>
	/// Xor
	/// </summary>
	/// <remarks>
	/// The identity is 0
	/// </remarks>
	public sealed class Ne:CombineI
	{

		static public readonly Ne Singleton = nilnul.obj.SingletonByDefault<Ne>.Instance;
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
