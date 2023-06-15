using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary_
{
	public class One : BinaryI, BinaryI1
		,
		IInvariate
	{
		public bool op(bool par, bool par1)
		{
			return true;
			//throw new NotImplementedException();
		}
		public const string TXT = "_1_";
		public override string ToString()
		{
			return TXT;
		}

		static public One Singleton
		{
			get
			{
				return nilnul._obj.Singleton<One>.Instance;
			}
		}

	}
}
