using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary_
{
	public class Head : BinaryI, BinaryI1,
		IUnivariate
	{
		public bool op(bool par, bool par1)
		{
			return par;
			//throw new NotImplementedException();
		}
		/// <summary>
		/// 
		/// </summary>
		/// ^
		///		confusing with xor ^
		///	$
		///		in currency, this begins
		///		in templated string, this begins.
		///		in regex, this ends
		///	
		public const string TXT = "$";
		public override string ToString()
		{
			return TXT;
		}


		static public Head Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Head>.Instance;
			}
		}

	}
}
