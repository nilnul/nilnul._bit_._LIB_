using nilnul.bit0nul.str.each_;
using nilnul.bit0nul.str.to_;
using nilnul.bit0nul.to_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit0nul.str.txten_
{
	static public class _AsNumsX
	{
		static public string AsNums(in IEnumerable<bool?> x) {
			return nilnul.obj.str._PhraseX.Phrase(
				x.ToNums()
			);
		}

		/// <summary>
		/// eg:
		///		021
		///	no fences; no separator;
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public string AsTernary(in IEnumerable<bool?> x) {
			return string.Join("",
				x.ToNums()
			);
		}


	}
}
