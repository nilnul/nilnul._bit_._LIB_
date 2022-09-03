using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary_
{
	public class NegTip : BinaryI, BinaryI1
		,
		IUnivariate
	{
		public bool op(bool par, bool par1)
		{
			return !par1;
			//throw new NotImplementedException();
		}

		public static string TXT = $"!{Tip.TXT}";
		public override string ToString()
		{
			return TXT;
		}

		static public NegTip Singleton
		{
			get
			{
				return nilnul._obj.Singleton<NegTip>.Instance;
			}
		}

	}
}
