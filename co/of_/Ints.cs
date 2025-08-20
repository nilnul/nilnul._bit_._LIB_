using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.co.of_
{
	static public class _IntsX
	{
		static public  (bool former, bool latter) Of(this in ( int x,  int y) a) {
			return  (
				nilnul.bit.of_._IntegerX.IsNonnil(in a.x)
				,
				nilnul.bit.of_._IntegerX.IsNonnil(in a.y)

			);
		}
	}
}
