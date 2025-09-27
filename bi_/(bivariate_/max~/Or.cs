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
	/// also known as
	///		max
	/// </remarks>
	///
	[Obsolete("as in maxterm, we use max. to make this go by one name, here we use max, not or")]
	public class Or : BinaryI, BinaryI1
	{
		public bool op(bool par, bool par1)
		{
			return par || par1;
			//throw new NotImplementedException();
		}
		public const string TXT = "|";
		public override string ToString()
		{
			return TXT;
		}


		static public Or Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Or>.Instance;
			}
		}

	}
}
