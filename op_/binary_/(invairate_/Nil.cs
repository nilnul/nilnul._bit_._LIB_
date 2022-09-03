using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary_
{
	public class Nil : BinaryI, BinaryI1
		,
		IInvariate
	{
		public bool op(bool par, bool par1)
		{
			return false;
			//throw new NotImplementedException();
		}

		public const string TXT = "_0_";
		public override string ToString()
		{
			return TXT;
		}


		static public Nil Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Nil>.Instance;
			}
		}

	}
}
