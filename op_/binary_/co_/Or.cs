using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.combine_
{
	/// <summary>
	/// Alias Max
	/// </summary>
	/// 

	public sealed class Or
		:
		nilnul.bit.CombineI
	{


		static public readonly Or Singleton = nilnul.obj.SingletonByDefault<Or>.Instance;


		static public bool Eval(bool x, bool y)
		{
			return x || y;

		}
		[Obsolete()]
		public Or()
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
