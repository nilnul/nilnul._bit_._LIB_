using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.combine_
{
	/// <summary>
	/// Alias !Max
	/// </summary>
	/// 


	public sealed class Nor:nilnul.bit.CombineI
	{



		static public readonly Nor Singleton = nilnul.obj.SingletonByDefault<Nor>.Instance;

		[Obsolete()]
		public Nor()
		{

		}
		public bool eval(bool x, bool y)
		{
			return !Or.Eval(x, y);

			throw new NotImplementedException();
		}
	}
}
