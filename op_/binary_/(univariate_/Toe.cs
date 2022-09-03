using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary_
{
	public class Toe : BinaryI, BinaryI1
		,
		IUnivariate
	{
		public bool op(bool par, bool par1)
		{
			return par1;
			//throw new NotImplementedException();
		}
		/// <summary>
		/// 
		/// </summary>
		/// $
		///		in regex, this means end
		///		in templated txt, this means begin.
		///	#
		public const string TXT = "#";
		public override string ToString()
		{
			return TXT;
		}

		static public Toe Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Toe>.Instance;
			}
		}

	}
}
