using nilnul.bit.str.each_;
using nilnul.bit.str.to_;
using nilnul.bit.to_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bits
{
	static public class _TxtenX
	{
	

		/// <summary>
		/// eg:
		///		01
		///	no fences; no separator; no prefix
		///
		/// note: it's reversed as compared with 0bxxxx.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public string NoSep(in IEnumerable<bool> x) {
			return string.Join("",
				x.ToNums()
			);
		}


	}
}
