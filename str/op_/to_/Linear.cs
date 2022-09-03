using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.str.op_.to_
{
	static public class _AsRadixX
	{
		


		/// <summary>
		/// first is the most significant bit.
		/// </summary>
		/// <param name="bits"></param>
		/// <returns></returns>
		static public int AsRadix(IEnumerable<bool> bits) {

			var r = 0;
			foreach (var item in bits)
			{
	
				r *= 2;
				r += nilnul.bit.op_.to_.ToIntX.ToInt(item) ;

			}
			return r;

		}

		static public int AsRadix_lastIsMostSignificant(IEnumerable<bool> bits) {

			return AsRadix(
				bits.Reverse()
			);

		}




	}
}
