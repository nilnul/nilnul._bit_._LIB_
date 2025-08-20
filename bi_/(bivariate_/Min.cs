using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary_
{
	/// <summary>
	/// min makes it easy to understand the distributiveness at:
	///		c > (a MIN b)= c>a MIN c>b
	///		c lt (a MIN b)= c lt a MIN c lt b
	///		
	/// </summary>
	/// <remarks>
	/// alias:
	///		multi
	///			only 1*1=1, 0 otherwise
	///		times
	///		min
	///			used in minterm
	///		mi
	///			min
	///		and
	/// </remarks>
	public class Min : BinaryI,BinaryI1
		,
		IBivariate
	{
		public bool op(bool par, bool par1)
		{
			return par && par1;
			//throw new NotImplementedException();
		}
		public const string TXT = "&";
		public override string ToString()
		{
			return TXT;
		}

		static public Min Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Min>.Instance;
			}
		}

	}
}
