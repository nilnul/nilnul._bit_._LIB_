using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op.binary
{
	/// <summary>
	/// Alias Max
	/// </summary>
	///
	[Obsolete()]
	public  class Max:
		bit.op.BinaryI
	{


		static public Max Singleton = SingletonByDefault<Max>.Instance;




		public bool eval(bool x, bool y)
		{
			return x || y;
			throw new NotImplementedException();
		}
	}
}
