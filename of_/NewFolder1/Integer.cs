using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.of_
{
	static public class _IntegerX
	{
		static public bool Op(int x) {
			return x != 0;
		}

		static public bool Op_ofNilOne(int x) {
			return x switch {
				0=>false
				,
				1=>true
				,
				_=> throw new ArgumentOutOfRangeException(
					$"only 0 and 1 can be converted to bool; {x} is not 0 nor 1."
				)
			};
		}

	}
}
