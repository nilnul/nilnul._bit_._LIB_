using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.combine_
{
	/// <summary>
	/// Alias !Min
	/// </summary>
	/// 
	public sealed class Nand: nilnul.bit.CombineI

	{


		static public readonly Nand Singleton = nilnul.obj.SingletonByDefault<Nand>.Instance;



		[Obsolete()]
		public Nand()
		{

		}



		public bool eval(bool x, bool y)
		{
			return !And.Eval(x, y);

			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return "\u22bc";
		}

	}
}
