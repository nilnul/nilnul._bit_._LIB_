using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// alias:
	///		multi
	///			only 1*1=1, 0 otherwise
	///		times
	///		min
	/// </remarks>
	///
	[Obsolete("in minterm, we use 'min'. so here we go by that name to avoid adding duplicate definition")]
	public class And : BinaryI,BinaryI1
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

		static public And Singleton
		{
			get
			{
				return nilnul._obj.Singleton<And>.Instance;
			}
		}

	}
}
