using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.to_
{
	static public class ToIntX
	{
		static public int ToInt(this bool x) {
			return x ? 1 : 0;
		}
		static public int ToNegPosOne(this bool x) {
			return x ? 1 : -1;
		}


	}
}
