using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.duo.op
{
	/// <summary>
	/// Alias Max
	/// </summary>
	/// 

	public sealed class Ma
		:nilnul.obj.duo.OpI<bool>
		,nilnul.bit.duo.OpI
		,nilnul.bit.duo.OpI1
	{


		static public readonly Ma Singleton = SingletonByDefault<Ma>.Instance;


		static public bool Eval(bool x, bool y)
		{
			return x || y;

		}
		[Obsolete()]
		public Ma()
		{

		}

		public bool eval(bool x, bool y)
		{
			return x || y;
			throw new NotImplementedException();
		}
		public override string ToString()
		{
			return "|";
		}
	}
}
