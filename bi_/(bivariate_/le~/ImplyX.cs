using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op
{
	[Obsolete()]
	static public  class ImplyX
	{
		/// <summary>
		/// x-->y
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		static public bool Eval(bool x,bool y) {
			if (x)
			{
				return y;
				
			}
			return true;
			
		}


		static public bool Eval_byExpr(bool x, bool y)
		{
			return !x || y;

		}
	}
}
