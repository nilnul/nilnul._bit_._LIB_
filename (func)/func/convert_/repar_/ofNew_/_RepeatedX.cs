using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.func.convert_.repar_.ofNew
{
	static public class _RepeatedX
	{
		static public nilnul.bit.FuncI2 Op(nilnul.bit.FuncI2 func, IEnumerable<nilnul.bit.VarI1> oldParS) {
			var r = func;
			foreach (var item in oldParS)
			{
				r = _OfNewX.Op(r, item);
			}
			return r;
		}
	}
}
