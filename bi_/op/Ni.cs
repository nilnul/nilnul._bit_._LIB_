using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.duo.op
{
	/// <summary>
	/// Alias !Min
	/// </summary>
	///

	[Obsolete(nameof(bit.op_.binary_.Nand))]
	public sealed class Ni:OpI
		, nilnul.bit.duo.OpI1

	{


		static public readonly Ni Singleton = SingletonByDefault<Ni>.Instance;



		[Obsolete()]
		public Ni()
		{

		}



		public bool eval(bool x, bool y)
		{
			return !Mi.Eval(x, y);

			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return "\u22bc";
		}

	}
}
