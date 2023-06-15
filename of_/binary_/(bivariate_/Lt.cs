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
	public class Lt : BinaryI, BinaryI1
		,
		IBivariate
	{
		public bool op(bool par, bool par1)
		{
			return !par && par1;
			//throw new NotImplementedException();
		}
		public const string TXT = "<";
		public override string ToString()
		{
			return TXT;
		}

		static public Lt Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Lt>.Instance;
			}
		}

	}
}
