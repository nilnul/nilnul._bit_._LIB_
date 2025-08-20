using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.duo.op
{
	/// <summary>
	/// Alias !Max
	/// </summary>
	/// 


	public sealed class Na:OpI
	{



		static public readonly Na Singleton = SingletonByDefault<Na>.Instance;

		[Obsolete()]
		public Na()
		{

		}
		public bool eval(bool x, bool y)
		{
			return !Ma.Eval(x, y);

			throw new NotImplementedException();
		}
	}
}
