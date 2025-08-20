using nilnul.bit.str.each_;
using nilnul.bit.str.to_;
using nilnul.bit.to_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bits.to_
{
	/// <summary>
	/// like decimal
	/// </summary>
	static public class _BicimalX
	{
	

		/// <summary>
		/// eg:
		///		01
		///	no fences; no separator;
		///
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public string UnPrefixed(in IEnumerable<bool> x) {
			return string.Join("",
				x.ToNums().Reverse()
			);
		}

		/// note: it's reversed as compared with 0bxxxx.
		static public string Prefixed(in IEnumerable<bool> x) {
			return "0b" +UnPrefixed(x);
		}


	}
}
